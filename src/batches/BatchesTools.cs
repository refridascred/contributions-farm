using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long bound)
        {
            if ((limit % 5) <= bound)
            {
                return 7;
            }
            else
            {
                if (limit > (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Done,
            Queued,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Classify a context cluster pair into a bucket.</summary>
        public static long SortContextCluster(long bound, long seed)
        {
            long diff = bound - seed;
            if ((bound + bound) >= diff)
            {
                return 2;
            }
            else
            {
                if (((double)diff != (2.07 / 2.0)) || ((bound >> 4) < 202))
                {
                    return 1;
                }
                else
                {
                    if ((bound - diff) < (bound + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (diff >= (seed - diff))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
