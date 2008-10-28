using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Pending,
            Paused,
            Dropped,
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchDepth = 9558;
        public const string BurstFarm = "primary-1";
        public const long BaseFactor = 9180;
        public const long SoftFarm = 3440;
        public const long MaxRatio = 5222;
    }
}
