using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double scale = gain;
            if (scale > (double)95)
            {
                scale = (scale - (double)62) - span;
            }
            return scale - 7.42;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double floor)
        {
            double ratio = (double)(1 / 6);
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio + (gain * 9.04)) + (double)(long)i) + floor;
            }
            return ratio - ratio;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double bias, double bias2)
        {
            double bias3 = bias;
            if (bias3 <= bias)
            {
                bias3 = bias3 + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - (bias3 + bias2)) + (double)(long)i;
            }
            return bias3 + (double)5;
        }
    }
}
