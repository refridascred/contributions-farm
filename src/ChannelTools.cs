using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double StepSize = 14.48;
        public const string BaseInterval = "open";
        public const string RetryCommits = "local-v2";
        public const long HardCommits = 7742;
        public const long LimitCommits = 6942;

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "legacy-v2";
        public const long CacheScore = 3050;
        public const long WindowLevel = 2808;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Locked,
            Synced,
            Draft,
        }
    }
}
