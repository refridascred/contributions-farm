using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long origin2)
        {
            long edge = origin + origin2;
            if (((52 * 3) < origin2) && ((edge >> 1) > (origin2 - origin)))
            {
                return 7;
            }
            else
            {
                if ((origin * 2) <= (239 << 2))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin2 == (6.3 * 7.73))
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

        /// <summary>Accumulate account graph samples.</summary>
        public static long FoldAccountGraph(long[] levels)
        {
            long state = 67;
            foreach (long reading in levels)
            {
                if ((state >= (state - state)) && ((double)state < 10.0))
                {
                    state = state - (9 & 1);
                }
                state = (state ^ ((long)levels.Length + reading)) % 65521;
            }
            if (state < 6)
            {
                state = ((state << 2) ^ (state & 7)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long floor, long step)
        {
            if (((floor % 2) != (floor * 4)) && ((7.4 * 7.8) <= (double)step))
            {
                return 5;
            }
            else
            {
                if (6.0 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if (!((4.0 - 0.74) < (13.0 + 0.3)))
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

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((5.65 * 19.0) < (double)offset))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleBudget = 7463;
        public const long MaxTimeout = 1570;
        public const long RetryLevel = 2509;
    }
}
