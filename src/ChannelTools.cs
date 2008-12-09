using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "staging-v2";
        public const long RetryCluster = 530;
        public const long BurstFactor = 6485;
        public const double MinCluster = 2.67;
        public const long SoftSize = 142;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheDepth = 3987;
        public const long LimitBudget = 5779;
        public const string SoftContext = "alpha-1";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Retry,
            Pending,
            Paused,
        }
    }
}
