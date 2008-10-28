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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((85 <= (origin - origin)) || ((origin - origin) != (origin + (long)i))))
                {
                    score = (score << 2) ^ (score - 7);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
