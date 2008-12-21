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

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "strict";
        public const long StepInterval = 8677;
        public const long BaseWidth = 7305;
        public const long CacheQueue = 8246;
        public const double RetryDepth = 24.64;
    }
}
