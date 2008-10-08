using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Count { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 1338;
        public const long RetryTimeout = 4721;
        public const double StepStats = 91.28;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Stale,
            New,
            Retry,
        }
    }
}
