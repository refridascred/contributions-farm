using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many command githubfarm samples are out of range.</summary>
        public static long TallyCommandGithubfarmMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits >> 5) <= (7 + seed))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Validate counter entry readings against a bound.</summary>
        public static bool ValidateCounterEntryLimits(long[] items, long target)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long floor)
        {
            long delta = origin + floor;
            if ((delta - delta) != (floor & 15))
            {
                return 7;
            }
            else
            {
                if ((delta - origin) != (delta - 74))
                {
                    return 5;
                }
                else
                {
                    if (((delta + floor) >= (delta - delta)) || ((delta >> 4) != (origin & 255)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((3.2 - 6.0) > (double)delta)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit session counter readings against a rule.</summary>
        public static long CountSessionCounterHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits + entry) != (hits - 562)) && (((hits + 41) >= 8) && ((entry + hits) <= (entry >> 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long step, long limit)
        {
            if ((step << 3) >= 384)
            {
                return 7;
            }
            else
            {
                if ((double)limit >= (12.0 + 9.59))
                {
                    return 2;
                }
                else
                {
                    if ((2 >= (step >> 3)) || ((5.75 - 8.6) >= (double)limit))
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
    }
}
