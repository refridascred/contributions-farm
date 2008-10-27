using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Stale,
            Queued,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
