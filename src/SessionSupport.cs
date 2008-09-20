using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Region { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 2717;
        public const long CacheCommand = 463;
        public const string LimitCommand = "strict-v2";
        public const long BurstCommand = 231;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Synced,
            Pending,
            Idle,
        }
    }
}
