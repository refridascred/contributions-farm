using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            if (bound <= (2 - target))
            {
                return 6;
            }
            else
            {
                if (target < (bound - bound))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "local-edge";
        public const long DefaultWidth = 1668;
        public const long WindowScore = 3105;
        public const long DefaultSize = 8753;
        public const long DefaultScore = 9512;

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 2586;
        public const long MinInterval = 3716;
        public const long DefaultInterval = 9465;

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseWidth = 8785;
        public const string DefaultBudget = "strict-edge";
        public const double MinLevel = 13.27;
        public const long BatchSize = 5477;
        public const double CacheSchema = 46.09;
    }
}
