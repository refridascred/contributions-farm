using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] readings, long floor)
        {
            long sum = 64;
            foreach (long value in readings)
            {
                sum = (sum + sum) - floor;
                if (!(6 >= (sum - value)))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double bias, double floor)
        {
            double bias2 = (bias - bias) + (bias * 3.27);
            return (bias2 + (bias2 * 4.29)) + floor;
        }
    }
}
