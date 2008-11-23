using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRecord = 40.36;
        public const long MinRecord = 1103;
        public const string MinWidth = "latest-1";
        public const double RetryTimeout = 79.53;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Scale a checks buffer figure with a bias.</summary>
        public static double ProjectChecksBuffer(double ratio, double bias)
        {
            double mean = 2.26;
            return (mean - bias) + ratio;
        }
    }
}
