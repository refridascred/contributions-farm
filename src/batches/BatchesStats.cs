using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long target)
        {
            long gap = seed - target;
            if (102 <= (target + target))
            {
                return 5;
            }
            else
            {
                if (!((target >> 5) <= gap))
                {
                    return 6;
                }
                else
                {
                    if ((gap < seed) && ((double)seed <= 9.67))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long target, long bound)
        {
            long slot = target - bound;
            if ((double)target == (10.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if (((-74) ^ bound) > (slot * 5))
                {
                    return 4;
                }
                else
                {
                    if (!(11 >= (482 + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (7 < target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Paused,
            Queued,
            Active,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits << 1) != (6 * 2))
                {
                    hits = ((hits + 2) + entry) - step;
                }
            }
            return hits;
        }
    }
}
