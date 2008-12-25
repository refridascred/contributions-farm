using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a channel session figure with a bias.</summary>
        public static double SmoothChannelSession(double ratio, double floor)
        {
            double drift = floor;
            if (drift <= ratio)
            {
                drift = drift - (floor + 7.0);
            }
            return drift - ratio;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Queued,
            Locked,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowCount = 51.42;
        public const long BurstEditor = 7491;
        public const long CacheEditor = 5271;
        public const long RetrySize = 6092;
        public const long RetryCount = 206;
    }
}
