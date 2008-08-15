using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitEntry = 6723;
        public const long IdleEntry = 9657;
        public const double MaxEntry = 18.83;
        public const long BurstEntry = 2953;
        public const long CacheRatio = 3426;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Synced,
            Closed,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double CacheCommits = 40.42;
        public const long MaxTimeout = 7804;
        public const double BurstSize = 87.44;
        public const long MaxCommits = 2944;
    }
}
