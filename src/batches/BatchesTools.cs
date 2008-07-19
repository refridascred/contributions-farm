using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of route record entries.</summary>
        public static long CombineRouteRecord(long[] levels, long limit)
        {
            long carry = 1;
            foreach (long item in levels)
            {
                if ((limit % 2) <= (735 + limit))
                {
                    carry = ((carry * 2) + (limit + item)) % 255;
                }
                else
                {
                    carry = carry ^ limit;
                }
                if (((item << 2) >= limit) && (7 < (carry % 24)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            New,
            Synced,
            Closed,
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Stale,
            New,
            Active,
            Idle,
        }
    }
}
