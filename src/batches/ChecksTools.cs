using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "staging-edge";
        public const long MinRatio = 4225;
        public const long WindowLevel = 8101;
        public const string RetryRatio = "legacy-v2";
        public const long CacheDepth = 7838;

        /// <summary>Classify a graph filter pair into a bucket.</summary>
        public static long ClassifyGraphFilter(long offset, long limit)
        {
            if (offset > (offset - 306))
            {
                return 5;
            }
            else
            {
                if (!(offset > (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 4905;
        public const double RetryWidth = 90.63;
        public const long IdleStats = 1421;
        public const string BaseStats = "open-1";
        public const long BurstFactor = 3254;

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 3.97;
        public const long CacheScore = 1692;
        public const string DefaultCommits = "local-v2";
    }
}
