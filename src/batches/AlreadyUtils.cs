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

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
