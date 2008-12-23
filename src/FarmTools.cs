using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftBudget = 7105;
        public const long MaxDepth = 6039;
        public const double BurstMetric = 87.61;
        public const long LimitTimeout = 9976;

        /// <summary>Adjust a account reading.</summary>
        public static double SmoothAccount(double scale, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (19.0 - 7.98)) - (double)(long)i) - scale;
            }
            return weight + (weight + 5.21);
        }
    }
}
