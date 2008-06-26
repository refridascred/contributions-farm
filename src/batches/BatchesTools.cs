using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate token contributi readings against a bound.</summary>
        public static bool CheckTokenContributiBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxScore = 42.76;
        public const string BatchInterval = "strict-1";
        public const double LimitCluster = 48.09;
        public const long SoftTimeout = 4941;
        public const long BatchSize = 3811;

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftWidth = 66.18;
        public const double StepTimeout = 49.66;
        public const string RetryCommits = "staging-edge";
        public const double LimitFactor = 40.13;
    }
}
