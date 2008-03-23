using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1474;
        public const long MinFactor = 5469;
        public const long HardOrder = 9718;
        public const double StepOrder = 94.35;

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
