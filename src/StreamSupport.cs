using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Synced,
            Ready,
            New,
            Closed,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Idle,
            Retry,
            Closed,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Idle,
            Draft,
            New,
            Locked,
            Paused,
        }
    }
}
