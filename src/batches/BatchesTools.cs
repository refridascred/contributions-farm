using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Region { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
