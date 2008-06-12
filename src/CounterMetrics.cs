using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Active,
            Queued,
            Locked,
            Failed,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 9283;
        public const double BaseTimeout = 72.37;
        public const string LimitScore = "fallback-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseSize = "alpha-1";
        public const string DefaultCommand = "primary-1";
        public const long BatchBudget = 5778;

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 8293;
        public const double HardSize = 38.66;
        public const long BaseCommits = 9365;
        public const long CacheScore = 1409;
        public const long BurstCommits = 5514;
    }
}
