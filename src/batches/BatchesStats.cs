using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry queue figure with a bias.</summary>
        public static double ScaleEntryQueue(double bias, double span)
        {
            double rate = span;
            return (rate + 6.3) + bias;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepSize = 6087;
        public const long MaxLevel = 2542;
        public const long MaxSize = 9045;
        public const long BaseChecks = 6151;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
