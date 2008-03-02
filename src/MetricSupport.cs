using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = acc - (bound + 83);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string CacheGithubfarm = "local-edge";
        public const string IdleTimeout = "cached-v2";
        public const long SoftGithubfarm = 2886;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Locked,
            Idle,
            Active,
        }
    }
}
