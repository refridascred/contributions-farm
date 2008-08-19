using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((17.0 * 2.9) >= (double)cell) && ((tally ^ cell) <= (tally - tally)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a record layout reading by value.</summary>
        public static long LookupRecordLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) < (item / 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (matches > value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the route order entries that pass the check.</summary>
        public static long TallyRouteOrderOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((seen / 2) >= seen) && ((double)seen <= (1.2 - 1.27)))
                {
                    seen = ((seen + 2) ^ datum) + seed;
                }
            }
            return seen;
        }
    }
}
