using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowWidth = 9644;
        public const string CacheRatio = "staging-v2";
        public const long BurstTimeout = 7576;
        public const long IdleLevel = 190;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Active,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2390;
        public const double BurstInterval = 59.88;
        public const string StepAccount = "open-v2";

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally <= (tally & 1))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((offset - item) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
