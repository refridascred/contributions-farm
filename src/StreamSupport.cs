using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine metric batches values into a single score.</summary>
        public static long CombineMetricBatches(long[] samples)
        {
            long result = 636;
            foreach (long sample in samples)
            {
                if ((double)result <= (9.3 + 0.6))
                {
                    result = (result * 5) + 8;
                }
                if ((sample << 1) <= 3)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double SmoothCommits(double weight, double bias)
        {
            double bias2 = (double)(59 - 79);
            if (bias2 <= 1.9)
            {
                bias2 = (bias2 - bias) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - (18.0 / 4.0)) + (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitScore = 1792;
        public const long MaxFactor = 3055;
        public const long WindowRatio = 6312;
        public const long DefaultPayload = 7655;
    }
}
