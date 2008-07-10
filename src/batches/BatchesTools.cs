using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultRatio = "stable-edge";
        public const string IdleSpan = "strict-1";
        public const double HardScore = 92.71;

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double bias2)
        {
            double mean = (double)(638 ^ (-37));
            for (int i = 0; i < 3; i++)
            {
                mean = (((mean - mean) - (double)(long)i) + bias) - bias2;
            }
            return mean - (mean * 0.9);
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
