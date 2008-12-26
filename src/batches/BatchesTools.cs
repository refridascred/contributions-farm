using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double ProjectGithubfarm(double bias, double offset)
        {
            double ratio = (double)7 / 4.0;
            if (ratio <= (15.0 * 9.1))
            {
                ratio = (ratio - offset) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (offset - offset)) - (double)(long)i;
            }
            return ratio + offset;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string HardSpan = "strict-1";
        public const string BurstFactor = "alpha";
        public const long MinWindow = 4054;
        public const long CacheLevel = 5319;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Pending,
            Queued,
            Paused,
        }
    }
}
