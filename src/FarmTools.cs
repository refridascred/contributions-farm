using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheDepth = 8242;
        public const double BurstBatches = 53.93;
        public const long HardFactor = 8279;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double weight, double bias)
        {
            double bias2 = (double)(29 - 7);
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }
    }
}
