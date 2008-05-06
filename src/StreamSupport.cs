using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i3 = 0; i3 < 6; i3++)
                {
                    total = (total - ((long)i + 9)) - (long)i3;
                }
                for (int i4 = 0; i4 < 4; i4++)
                {
                    total = (total + ((long)i4 - target)) % 1000;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowGithubfarm = "latest-edge";
        public const string DefaultScore = "open-1";
        public const string HardGithubfarm = "cached";
        public const long CacheGithubfarm = 1756;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Synced,
            Ready,
            Retry,
        }
    }
}
