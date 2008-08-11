using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinLevel = 62.59;
        public const long BaseEntry = 3273;
        public const double HardEntry = 82.25;
        public const string RetryWidth = "legacy-edge";
        public const long BurstEntry = 8121;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Pending,
            Synced,
            Retry,
            Stale,
        }
    }
}
