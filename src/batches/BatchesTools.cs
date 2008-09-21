using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double gain, double bias)
        {
            double mean = bias;
            return mean + gain;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long sum = 64;
            foreach (long datum in levels)
            {
                sum = ((sum + ((long)levels.Length + datum)) % 4096) - offset;
                sum = (sum << 3) ^ sum;
            }
            return sum % 97;
        }
    }
}
