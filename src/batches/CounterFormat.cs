using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 3629;
        public const double MaxTools = 43.68;
        public const long SoftSize = 4146;
        public const double CacheRatio = 2.3;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double floor)
        {
            double gain2 = 9.0;
            if (gain2 >= gain2)
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - floor;
            }
            return gain2 - (gain + gain);
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 2) ^ sum) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
