using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Idle,
            Paused,
            Dropped,
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Stamp { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
