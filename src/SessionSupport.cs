using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((7.53 - 12.0) < (double)hits) || (hits >= (hits << 2)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a stats graph pair into a bucket.</summary>
        public static long GradeStatsGraph(long seed, long target)
        {
            long prev = seed + target;
            if ((seed <= (178 >> 3)) || (prev > (target << 3)))
            {
                return 3;
            }
            else
            {
                if ((seed << 3) <= 31)
                {
                    return 7;
                }
                else
                {
                    if ((target + 889) > (target + seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long target)
        {
            if (target >= 490)
            {
                return 6;
            }
            else
            {
                if (!((double)bound == (19.0 * 8.57)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
