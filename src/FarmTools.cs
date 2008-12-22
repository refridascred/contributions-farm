using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
