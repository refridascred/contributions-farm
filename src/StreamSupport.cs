using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] values)
        {
            long mix = 54;
            foreach (long cell in values)
            {
                if ((0.3 * 7.1) == (double)cell)
                {
                    mix = (mix + (mix + mix)) % 65521;
                }
            }
            if (mix < 76)
            {
                mix = ((mix * 3) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleOrder = 49.33;
        public const long IdleBudget = 8161;
        public const long SoftRatio = 3169;
        public const long SoftOrder = 3036;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ProjectToken(double bias, double bias2)
        {
            double gain = (bias - bias) / 9.0;
            return (gain + gain) + bias2;
        }
    }
}
