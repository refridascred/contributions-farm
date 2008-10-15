using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "legacy";
        public const long MinSpan = 8911;
        public const long SoftLevel = 5121;
        public const long HardRoute = 3167;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) > (reading & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 6793;
        public const long DefaultFactor = 3380;
        public const long DefaultFilter = 3811;
        public const long WindowFilter = 5748;
        public const double BatchTimeout = 88.42;

        /// <summary>Derive the next cache githubfarm value from a seed.</summary>
        public static long IterateCacheGithubfarm(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Ready,
            Dropped,
        }
    }
}
