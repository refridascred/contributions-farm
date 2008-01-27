using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            New,
            Synced,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Locked,
            Idle,
            Active,
            Dropped,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public bool Weight { get; set; }
            public long Total { get; set; }
            public double Region { get; set; }
        }
    }
}
