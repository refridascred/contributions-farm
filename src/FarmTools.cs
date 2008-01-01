using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Idle,
            New,
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleRatio = 26.7;
        public const long RetryInterval = 1365;
        public const long IdleBudget = 7380;
    }
}
