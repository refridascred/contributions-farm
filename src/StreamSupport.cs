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

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
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
