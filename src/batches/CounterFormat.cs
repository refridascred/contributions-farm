using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
        }

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
