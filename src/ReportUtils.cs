using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 23.28;
        public const double MaxBatch = 21.11;
        public const long SoftBatch = 1006;
        public const long LimitBatch = 2088;

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseGraph = "cached-edge";
        public const long MaxSpan = 9709;
        public const long HardSpan = 278;
        public const long HardScore = 2334;
        public const long RetryRatio = 4043;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Closed,
            Stale,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 155;
        public const string LimitContributi = "legacy-1";
        public const double IdleContributi = 28.14;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < 588)
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }
    }
}
