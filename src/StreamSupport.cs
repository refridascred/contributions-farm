using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9188;
        public const long BatchRatio = 3539;
        public const long SoftLevel = 8600;

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double rate, double bias)
        {
            double gain = (double)795;
            if (gain < (double)5)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + (rate * 2.7);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - rate;
        }
    }
}
