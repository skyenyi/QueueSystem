﻿using DAL;
using Model;

namespace BLL
{
    public class TBusinessAttributeBLL : BLLBase<TBusinessAttributeDAL, TBusinessAttributeModel>
    {
        public TBusinessAttributeBLL()
            : base()
        {
        }

        public TBusinessAttributeBLL(string connName)
            : base(connName)
        {
        }

        public TBusinessAttributeBLL(string connName, string areaNo)
            : base(connName, areaNo)
        {
        }

        public object GetGridData()
        {
            return this.CreateDAL().GetGridData();
        }

        public object GetGridDataByUnitSeq(string unitSeq)
        {
            return this.CreateDAL().GetGridDataByUnitSeq(unitSeq);
        }

        public object GetGridDetailData(string unitSeq, string busiSeq)
        {
            return this.CreateDAL().GetGridDetailData(unitSeq, busiSeq);
        }


        public bool IsBasic
        {
            get { return true; }
        }
    }
}
