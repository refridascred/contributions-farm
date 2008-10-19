using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 4853;
        public const double IdleCluster = 2.85;
        public const long DefaultCluster = 1462;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Paused,
            Stale,
            Active,
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
