using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a cache entry value against two limits.</summary>
        public static long BucketCacheEntry(long seed, long limit)
        {
            if (limit <= (seed + limit))
            {
                return 7;
            }
            else
            {
                if (!(3.41 >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit - seed) == (limit ^ seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit + limit) == (limit - seed)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long StepBatchesWindow(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
