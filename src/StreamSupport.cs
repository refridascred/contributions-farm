using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 1516;
        public const long RetryContext = 8868;
        public const long IdleContext = 6733;
        public const long StepContext = 4580;
        public const string WindowInterval = "standard-1";

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
