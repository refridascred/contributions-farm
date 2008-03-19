using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8;
        public const double BaseSpan = 47.62;
        public const long RetryScore = 841;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Retry,
            Failed,
            Done,
            New,
            Pending,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Dropped,
            Draft,
            Closed,
            Idle,
        }
    }
}
