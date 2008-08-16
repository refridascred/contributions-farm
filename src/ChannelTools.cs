using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 3455;
        public const double BurstWidth = 62.23;
        public const long MinFactor = 4586;
        public const double MaxMetric = 74.91;
        public const double WindowTimeout = 80.25;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public double Label { get; set; }
        }
    }
}
