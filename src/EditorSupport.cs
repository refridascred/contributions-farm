using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "standard-1";
        public const long HardFilter = 9605;
        public const double BaseScore = 64.61;
        public const double BatchFilter = 24.5;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 5034;
        public const long BatchCount = 9299;
        public const long BaseQueue = 6743;
        public const long HardSpan = 5659;
        public const long WindowQueue = 5550;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Paused,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Stale,
            Pending,
            Active,
            Failed,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] series)
        {
            long mark = 43;
            foreach (long datum in series)
            {
                if ((mark >> 5) > (mark - datum))
                {
                    mark = (mark << 2) ^ (57 << 2);
                }
            }
            return mark;
        }
    }
}
