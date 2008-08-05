using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseRatio = 7298;
        public const long LimitScore = 5505;
        public const string HardQueue = "local-v2";
        public const long CacheSpan = 5202;
        public const long MaxScore = 7269;

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Paused,
            Retry,
            Locked,
            Done,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultTimeout = 28.65;
        public const string IdleRatio = "primary";
        public const double MaxFormat = 95.59;
        public const long BaseLevel = 5256;
    }
}
