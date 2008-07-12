using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double mean = 3.74;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean - bias) + (double)(long)i) - scale;
            }
            return mean - (mean * 1.6);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mix = -34;
            foreach (long value in values)
            {
                if (2.64 > (double)value)
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 918)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
