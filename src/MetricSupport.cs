using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (6 < (origin / 7))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultBudget = 3473;
        public const double HardSession = 81.15;
        public const double CacheSession = 34.91;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((((double)seen == (9.2 - 9.81)) || ((466 & 127) == (entry >> 5))) && ((double)entry < (3.18 - 2.95)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
