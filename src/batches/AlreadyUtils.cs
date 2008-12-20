using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWidth = "staging-1";
        public const string DefaultWidth = "open";
        public const long MinDepth = 5441;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Retry,
            Locked,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinStats = "fallback-edge";
        public const long LimitTimeout = 8499;
        public const double MaxSize = 45.54;
        public const long MaxDepth = 8430;
        public const long RetryStats = 126;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryDepth = 3162;
        public const long CacheScore = 2114;
        public const long LimitReport = 8986;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Locked,
            Stale,
            Active,
            Synced,
        }
    }
}
