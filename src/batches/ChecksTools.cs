using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long carry = 36;
            foreach (long value in readings)
            {
                if (((value / 5) != (2 + carry)) && (value >= (value & 255)))
                {
                    break;
                }
                if ((offset - offset) < ((long)readings.Length + carry))
                {
                    carry = carry ^ 971;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultBudget = 7899;
        public const long IdleDepth = 9868;
        public const long LimitStats = 4983;

        /// <summary>Scale a support editor figure with a bias.</summary>
        public static double SmoothSupportEditor(double ratio, double floor)
        {
            double bias = ratio;
            if (bias >= (9.6 - ratio))
            {
                bias = (bias + (15.0 * 16.0)) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (2.9 * 4.1)) + (double)(long)i;
            }
            return bias - 13.0;
        }
    }
}
