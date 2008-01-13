using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 1078;
        public const long SoftGithubfarm = 9141;
        public const long MinCount = 6900;
        public const string LimitInterval = "alpha";
        public const string BurstGithubfarm = "strict";

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstQueue = 30.17;
        public const long MaxQueue = 3669;
        public const long CacheScore = 8769;
    }
}
