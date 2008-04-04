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

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }

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
