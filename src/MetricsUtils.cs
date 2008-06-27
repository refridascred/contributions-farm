using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((offset + 5) >= (6 % 10)))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepBudget = 45.44;
        public const double DefaultReport = 4.35;
        public const long RetryFactor = 477;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitTimeout = 2.78;
        public const long BurstMetrics = 9510;
        public const long BatchMetrics = 3065;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Closed,
            Retry,
            Draft,
            Idle,
            Dropped,
        }
    }
}
