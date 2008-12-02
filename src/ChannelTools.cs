using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Size { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 3379;
        public const string LimitCounter = "legacy-edge";
        public const long SoftCount = 2440;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstBudget = 595;
        public const long IdleMetric = 8261;
        public const long HardMetric = 8249;
        public const string MinDepth = "strict-v2";
    }
}
