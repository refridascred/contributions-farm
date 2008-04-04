using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowScore = 1842;
        public const double BatchDepth = 2.55;
        public const long HardToken = 2539;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            New,
            Stale,
            Failed,
            Draft,
        }
    }
}
