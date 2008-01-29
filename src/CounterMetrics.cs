using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySpan = 3308;
        public const long BaseSpan = 3905;
        public const long CacheWidth = 3872;
        public const long SoftWindow = 2837;

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            New,
            Paused,
            Synced,
            Idle,
        }
    }
}
