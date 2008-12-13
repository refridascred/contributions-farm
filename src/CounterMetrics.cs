using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "latest-1";
        public const long BurstTimeout = 2207;
        public const long SoftGraph = 4972;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Synced,
            Closed,
            Stale,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen - entry) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 59.59;
        public const string WindowBatch = "strict";
        public const long HardBatch = 9767;
        public const double DefaultWidth = 60.36;
    }
}
