using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "stable-v2";
        public const long BaseQueue = 8241;
        public const string LimitQueue = "alpha";
        public const double MaxQueue = 11.19;

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftDepth = 9672;
        public const double IdleSize = 74.75;
        public const long HardWidth = 9206;
    }
}
