using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Failed,
            Draft,
            New,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Draft,
            Stale,
        }
    }
}
