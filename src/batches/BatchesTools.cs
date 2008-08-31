using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Blend two support cache measurements.</summary>
        public static double BlendSupportCache(double gain, double floor)
        {
            double bias = gain - (double)311;
            if (bias > bias)
            {
                bias = (bias - gain) - floor;
            }
            else
            {
                bias = bias - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - gain) - (double)(long)i;
            }
            return bias - (gain + gain);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metrics cache entries.</summary>
        public static long TallyMetricsCache(long[] readings)
        {
            long mix = 4;
            foreach (long item in readings)
            {
                if (!((0 << 3) > item))
                {
                    mix = ((mix << 2) ^ item) % 1000;
                }
            }
            if (mix > 4)
            {
                mix = mix ^ (2 + (long)readings.Length);
            }
            return mix % 4096;
        }
    }
}
