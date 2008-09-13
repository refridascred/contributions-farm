using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 1195;
        public const long WindowCounter = 2252;
        public const long LimitCounter = 864;
        public const long DefaultRatio = 9504;

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Locked,
            New,
            Retry,
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Closed,
            Active,
            Draft,
            Stale,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 8666;
        public const double MaxTimeout = 65.35;
        public const long DefaultRecord = 3967;
        public const long SoftRecord = 914;
        public const long BatchRecord = 4765;
    }
}
