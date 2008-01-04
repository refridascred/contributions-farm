using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a batches figure with a bias.</summary>
        public static double ProjectBatches(double gain, double offset)
        {
            double bias = offset + gain;
            if (bias >= 6.81)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + offset) + (double)(long)i;
            }
            return bias - (double)83;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 8718;
        public const long IdleGithubfarm = 5939;
        public const double HardLevel = 44.27;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double gain = (double)(591 + 99);
            if (gain < (bias + bias))
            {
                gain = (gain - gain) - scale;
            }
            else
            {
                gain = gain - 6.0;
            }
            return gain - (7.3 / 8.0);
        }
    }
}
