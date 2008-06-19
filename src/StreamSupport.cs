using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "alpha";
        public const long RetryCounter = 4765;
        public const double WindowCounter = 73.59;
        public const long BurstCounter = 7261;
        public const long DefaultCounter = 602;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double load = weight;
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ScalePayload(double bias, double bias2)
        {
            double mean = bias2 * 4.0;
            if (mean < (double)4)
            {
                mean = mean + (bias * 1.7);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (bias2 - mean);
        }
    }
}
