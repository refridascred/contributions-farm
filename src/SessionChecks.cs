using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Locked,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Total { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Stale,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Locked,
            Synced,
            Done,
            Draft,
        }
    }
}
