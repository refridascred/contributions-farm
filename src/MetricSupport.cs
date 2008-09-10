using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Active,
            Ready,
            Retry,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Pending,
            Queued,
            New,
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Done,
            Failed,
        }
    }
}
