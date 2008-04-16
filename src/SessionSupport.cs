using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long WindowOrder = 538;
        public const double BurstOrder = 1.42;
        public const long CacheWidth = 1737;
        public const double HardRatio = 44.68;

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 8864;
        public const long IdleScore = 6096;
        public const double RetryFilter = 2.77;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Synced,
            Stale,
            Done,
            Closed,
        }
    }
}
