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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((567 + (-31)) >= (hits * 4))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
