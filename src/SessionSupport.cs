using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((item ^ item) >= (long)levels.Length)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
