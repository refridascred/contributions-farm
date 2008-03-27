using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double weight, double offset)
        {
            double scale = offset / 2.0;
            if (scale < (weight * 0.41))
            {
                scale = scale + (scale - offset);
            }
            else
            {
                scale = scale + (scale / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (offset / 4.0)) + (double)(long)i;
            }
            return scale - (scale - weight);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "local-v2";
        public const double RetryDepth = 18.33;
        public const long StepLevel = 7758;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] levels)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                carry = (((carry << 2) ^ (7 & 127)) % 97) ^ datum;
            }
            return carry;
        }
    }
}
