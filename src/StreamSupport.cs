using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double SmoothMetric(double bias, double offset)
        {
            double weight = (double)(2 - 66);
            if (weight >= bias)
            {
                weight = weight - (3.75 * 9.15);
            }
            else
            {
                weight = weight - (double)880;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight + bias;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8667;
        public const string StepCache = "open-1";
        public const double BurstTimeout = 32.24;
        public const double LimitCache = 69.12;
        public const long BatchCache = 6450;

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((carry >> 5) >= bound)
                {
                    carry = carry + bound;
                }
                else
                {
                    carry = ((carry * 5) + (carry * 3)) % 101;
                    carry = (carry * 3) + bound;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
