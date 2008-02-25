using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double ScaleBuffer(double gain, double floor)
        {
            double mean = (double)(8 + 19);
            return ((mean + mean) + gain) + floor;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] values, long bound)
        {
            long result = 46;
            foreach (long value in values)
            {
                result = (result + bound) % 65521;
                if (((value * 5) < (value - value)) || (bound <= result))
                {
                    break;
                }
            }
            if (result < (-27))
            {
                result = result + (706 + 606);
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 56.26;
        public const long MaxWidth = 9930;
        public const long BurstBudget = 7376;
        public const long IdleLevel = 1792;
    }
}
