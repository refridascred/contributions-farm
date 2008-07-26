using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Blend two tools farm measurements.</summary>
        public static double AdjustToolsFarm(double gain, double span)
        {
            double weight = (double)(38 * 2);
            return ((weight + 2.82) + gain) + span;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double gain = (bias - floor) - 17.0;
            if (gain > (8.6 * 2.44))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - 9.27;
            }
            return gain - 7.2;
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long WeighAccountMetric(long[] readings)
        {
            long carry = 5;
            foreach (long entry in readings)
            {
                if ((carry - entry) <= entry)
                {
                    carry = ((carry * 3) + (entry & 3)) % 4096;
                }
                else
                {
                    carry = (carry * 5) + 4;
                }
                carry = carry ^ (entry & 3);
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 366;
        public const long IdleSize = 6605;
        public const long MaxSize = 2552;
        public const long CacheDepth = 8462;
        public const string BaseProfile = "fallback-1";

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double bias, double offset)
        {
            double drift = bias;
            if (drift > (offset / 6.0))
            {
                drift = drift + (double)14;
            }
            else
            {
                drift = drift - (double)173;
            }
            return drift + (drift * 4.36);
        }
    }
}
