using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long target)
        {
            if ((double)(-154) < (double)target)
            {
                return 6;
            }
            else
            {
                if ((double)target > 8.0)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string SoftWidth = "stable-edge";
        public const string BatchBudget = "cached";
        public const string BatchCommits = "fallback-v2";
        public const long WindowCommits = 2452;
        public const double BatchScore = 76.6;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            New,
            Stale,
            Idle,
        }
    }
}
