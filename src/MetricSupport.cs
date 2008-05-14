using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Synced,
            Ready,
            Locked,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 3871;
        public const double WindowSpan = 68.25;
        public const string BaseSpan = "strict";
        public const long SoftScore = 34;
        public const long BaseSize = 4230;
    }
}
