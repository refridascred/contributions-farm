using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Ready,
            Synced,
            Locked,
            New,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Label { get; set; }
            public long Limit { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Level { get; set; } = "";
            public bool Weight { get; set; }
            public double Label { get; set; }
        }
    }
}
