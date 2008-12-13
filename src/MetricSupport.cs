using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Closed,
            Failed,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
            public bool Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
