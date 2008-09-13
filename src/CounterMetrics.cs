using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 4205;
        public const string WindowDepth = "staging-edge";
        public const long HardAccount = 7300;

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheFactor = 24.78;
        public const string LimitScore = "cached-v2";
        public const long BurstEditor = 3755;
        public const long WindowEditor = 7599;

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
