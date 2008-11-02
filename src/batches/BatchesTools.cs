using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long HardRatio = 7846;
        public const string BatchWidth = "fallback-1";
        public const string BatchRatio = "local";
        public const string LimitSupport = "fallback-v2";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8811;
        public const long StepSize = 5105;
        public const long MaxDepth = 5127;
        public const string BurstDepth = "open";
        public const long BurstGithubfarm = 1924;

        /// <summary>Project the next buffer queue value.</summary>
        public static double SmoothBufferQueue(double gain, double bias)
        {
            double weight = (gain * 7.76) * 0.2;
            if (weight <= (3.7 / 8.0))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight + (weight - bias)) + (double)(long)i;
            }
            return weight + bias;
        }
    }
}
