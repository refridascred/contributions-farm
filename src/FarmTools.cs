using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double bias, double offset)
        {
            double scale = 9.24;
            for (int i = 0; i < 5; i++)
            {
                scale = ((scale + offset) - (double)(long)i) + bias;
            }
            return scale - (offset + offset);
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double ratio, double bias)
        {
            double mean = 1.0;
            if (mean >= 5.0)
            {
                mean = (mean + mean) - ratio;
            }
            return mean + (bias + mean);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryLevel = 4446;
        public const string SoftGithubfarm = "alpha-edge";
        public const long BurstDepth = 5023;
        public const double StepScore = 47.07;
        public const long WindowScore = 4702;
    }
}
