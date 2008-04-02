using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double ratio, double bias)
        {
            double load = bias;
            if (load < ratio)
            {
                load = load - (double)551;
            }
            return load + 9.15;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double scale2 = scale + offset;
            if (scale2 >= 0.31)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (scale2 / 6.0)) + (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
