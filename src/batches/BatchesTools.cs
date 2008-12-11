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

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double weight = 0.38;
            if (weight <= 6.0)
            {
                weight = (weight - (0.1 / 3.0)) + bias;
            }
            else
            {
                weight = weight - (scale + 8.7);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + scale) - (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Ready,
            Pending,
            Idle,
            Retry,
        }
    }
}
