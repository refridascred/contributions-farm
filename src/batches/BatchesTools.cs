using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseRatio = 56.57;
        public const long StepGithubfarm = 9469;
        public const long HardGithubfarm = 1019;
        public const double CacheGithubfarm = 24.99;
        public const string IdleInterval = "standard-v2";

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double span)
        {
            double scale = (span / 2.0) / 3.0;
            if (scale < span)
            {
                scale = (scale + (double)(-7)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)680) + (double)(long)i;
            }
            return scale - (scale / 6.0);
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Stale,
            Paused,
            Draft,
            Pending,
            Ready,
        }
    }
}
