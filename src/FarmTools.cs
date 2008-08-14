using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            New,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 16.76;
        public const long SoftWidth = 3869;
        public const double BaseFactor = 91.21;

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowCount = 2757;
        public const double WindowLevel = 75.67;
        public const string RetryMetric = "standard-1";
    }
}
