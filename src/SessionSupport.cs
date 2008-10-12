using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultCluster = 11.22;
        public const long BurstCluster = 4123;
        public const long CacheRatio = 741;
        public const double BatchCluster = 37.62;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Synced,
            Retry,
            Paused,
        }
    }
}
