using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double BlendBatches(double scale, double bias)
        {
            double weight = 9.0 - 3.6;
            return ((weight - (weight / 2.0)) + scale) + bias;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double bias, double bias2)
        {
            double gain = bias2;
            if (gain <= (bias - gain))
            {
                gain = gain + bias;
            }
            return gain - (gain + bias2);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "fallback";
        public const long CacheCount = 356;
        public const long RetryBudget = 9446;
        public const long BurstWidth = 2807;
    }
}
