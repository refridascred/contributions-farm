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

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepQueue = "stable-v2";
        public const long BaseQueue = 8241;
        public const string LimitQueue = "alpha";
        public const double MaxQueue = 11.19;

        /// <summary>Project the next metric batches value.</summary>
        public static double BlendMetricBatches(double gain, double floor)
        {
            double ratio = gain;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - floor) + (double)(long)i;
            }
            return ratio - floor;
        }
    }
}
