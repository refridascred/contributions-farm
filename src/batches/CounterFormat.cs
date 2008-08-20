using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            New,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5145;
        public const long RetryBatch = 6618;
        public const double SoftWidth = 89.94;
        public const string MaxInterval = "stable-1";

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }
    }
}
