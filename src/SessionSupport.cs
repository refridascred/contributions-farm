using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the metric stats entries that pass the check.</summary>
        public static long TallyMetricStatsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((12.0 / 7.0) == (double)datum)
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) > (cell + cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const long DefaultFactor = 2566;
        public const long StepScore = 5287;
        public const string CacheSize = "fallback-v2";
        public const long RetryChecks = 3592;
    }
}
