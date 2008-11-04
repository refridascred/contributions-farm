using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "legacy-v2";
        public const long BaseEntry = 2051;
        public const long HardEntry = 6643;
        public const string HardCount = "local-edge";

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 9814;
        public const double BaseAccount = 15.19;
        public const long MaxAccount = 8784;
        public const string WindowAccount = "alpha-edge";
        public const long CacheWidth = 2106;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Done,
            Queued,
            Synced,
            Idle,
        }
    }
}
