using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Pending,
            Ready,
            Active,
            Done,
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Pending,
            Done,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Level { get; set; }
            public long Offset { get; set; }
        }
    }
}
