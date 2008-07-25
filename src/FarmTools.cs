using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7533;
        public const long StepTimeout = 5675;
        public const long WindowFactor = 2682;
        public const double WindowCommits = 61.13;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = sum - ((long)i - sum);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Failed,
            Locked,
        }
    }
}
