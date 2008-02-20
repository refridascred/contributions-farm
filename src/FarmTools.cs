using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long MaxWindow = 8233;
        public const long BurstWindow = 539;
        public const long RetryLevel = 826;
        public const long LimitTimeout = 7455;
        public const long IdleWidth = 6869;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Synced,
            Dropped,
            Retry,
            Pending,
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
