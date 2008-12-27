using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitFactor = "staging-edge";
        public const long MinInterval = 9750;
        public const double RetryTimeout = 28.78;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            New,
            Queued,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string CacheLevel = "latest-edge";
        public const long HardSpan = 2191;
        public const long HardInterval = 6546;
    }
}
