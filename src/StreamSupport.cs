using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double rate = gain;
            if (rate < rate)
            {
                rate = (rate + (double)0) - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (gain / 2.0)) + (double)(long)i;
            }
            return rate + (rate / 5.0);
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!((carry - floor) == (floor + floor)))
                {
                    carry = (carry - (floor + (-354))) % 101;
                }
                if ((carry ^ floor) == (159 * 2))
                {
                    carry = (carry << 3) ^ (floor >> 4);
                    carry = (carry + ((long)i + floor)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double floor)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 - (double)0) + (double)(long)i) + floor;
            }
            return bias2 - (bias2 - bias);
        }
    }
}
