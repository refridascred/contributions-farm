using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Count { get; set; }
            public long Label { get; set; }
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Done,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Label { get; set; }
        }
    }
}
