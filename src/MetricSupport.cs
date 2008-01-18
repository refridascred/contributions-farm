using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Dropped,
            Pending,
            Draft,
            Stale,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Ratio { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Weight { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
