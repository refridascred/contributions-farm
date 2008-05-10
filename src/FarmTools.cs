using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double weight, double span)
        {
            double bias = span / 9.0;
            if (bias <= (double)0)
            {
                bias = (bias - span) - weight;
            }
            return bias - 3.0;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double rate, double offset)
        {
            double gain = offset;
            if (gain >= 1.0)
            {
                gain = (gain - offset) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)319) + (double)(long)i;
            }
            return gain + (double)6;
        }
    }
}
