using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Queued,
            Stale,
            Pending,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 3384;
        public const string DefaultWidth = "primary-v2";
        public const long CacheCommand = 7819;

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 6877;
        public const string BaseDepth = "legacy-edge";
        public const long BatchCount = 1371;
    }
}
