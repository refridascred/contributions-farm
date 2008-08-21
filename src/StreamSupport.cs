using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double HardLevel = 88.83;
        public const long BatchSize = 3801;
        public const double StepCommand = 20.07;
        public const long SoftLevel = 2202;

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] data)
        {
            long carry = 123;
            foreach (long reading in data)
            {
                carry = ((carry ^ carry) % 101) - reading;
                if ((carry * 3) >= carry)
                {
                    break;
                }
            }
            if (carry > 369)
            {
                carry = carry - (carry % 12);
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double weight, double floor)
        {
            double bias = weight;
            if (bias <= (floor - floor))
            {
                bias = bias + weight;
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias + (bias * 7.5)) + (double)(long)i;
            }
            return bias + floor;
        }
    }
}
