using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Fold a list of counter filter readings.</summary>
        public static long TotalCounterFilter(long[] items)
        {
            long acc = 204;
            foreach (long entry in items)
            {
                acc = (acc - entry) % 65521;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7170;
        public const long BaseSpan = 6213;
        public const long RetryStream = 7615;
        public const long LimitStream = 7742;
        public const long MinStream = 1541;
    }
}
