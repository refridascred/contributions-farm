using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((sample << 1) > (hits * 4)) && ((limit >> 5) <= (3 + hits))) || ((double)limit >= (double)sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Rank batches profile input into a small class.</summary>
        public static long BucketBatchesProfile(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (((floor - floor2) < cur) && ((14 & 127) == (floor2 - floor2)))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) > (floor ^ floor))
                {
                    return 1;
                }
                else
                {
                    if ((2.9 * 2.62) == (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long target, long seed)
        {
            if (((seed ^ 6) != (7 * 3)) && ((12.0 - 8.2) > (double)seed))
            {
                return 4;
            }
            else
            {
                if ((8.64 / 2.0) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if ((seed + seed) != (seed ^ seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed & 3) != (target - target)) || (1.3 <= (double)target))
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

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Queued,
            Draft,
        }
    }
}
