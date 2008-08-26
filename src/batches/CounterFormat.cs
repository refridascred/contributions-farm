using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitDepth = "cached-edge";
        public const long IdleOrder = 4999;
        public const double BurstOrder = 32.77;
        public const double CacheRatio = 77.17;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Stale,
            Pending,
            Synced,
            Paused,
        }
    }
}
