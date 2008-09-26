using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 5537;
        public const long MinAccount = 2142;
        public const long BurstAccount = 5478;
        public const string CacheAccount = "local-v2";
        public const long LimitScore = 7639;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long origin)
        {
            if ((double)bound != (7.7 / 5.0))
            {
                return 7;
            }
            else
            {
                if ((9.0 * 0.02) < (double)bound)
                {
                    return 5;
                }
                else
                {
                    if (origin > (bound + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin ^ 876) >= (origin % 12))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + value) < tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
