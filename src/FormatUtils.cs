using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first batch window entry that matches the target.</summary>
        public static long SeekBatchWindowIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Stale,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((320 + value) <= 612)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen < (6.4 + 14.0))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 2814;
        public const long MaxFactor = 7490;
        public const string HardAlready = "primary-1";

        /// <summary>Audit batch report readings against a rule.</summary>
        public static long CountBatchReportOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (count < 62)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }
    }
}
