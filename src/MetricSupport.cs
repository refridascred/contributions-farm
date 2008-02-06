using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every githubfarm profile entry stays within the limit.</summary>
        public static bool ValidateGithubfarmProfileLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 3826;
        public const long RetryRecord = 5878;
        public const string MaxRecord = "cached-edge";

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSpan = 922;
        public const string CacheChecks = "local";
        public const string LimitWidth = "stable-1";
        public const long SoftChecks = 7790;
        public const string BatchDepth = "alpha-edge";
    }
}
