using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank window order input into a small class.</summary>
        public static long BucketWindowOrder(long limit, long floor)
        {
            long cur = limit + floor;
            if (993 > (limit >> 1))
            {
                return 0;
            }
            else
            {
                if (cur > (limit >> 5))
                {
                    return 4;
                }
                else
                {
                    if ((floor ^ 85) == (572 / 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if (cur > 637)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate batches context samples.</summary>
        public static long ScoreBatchesContext(long[] items)
        {
            long total = 0;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    total = (total - (item << 1)) % 65521;
                    total = (total << 2) ^ ((long)i ^ item);
                }
                if (total > item)
                {
                    total = ((total * 2) + (total * 2)) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
