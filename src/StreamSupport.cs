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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double SmoothContributi(double scale, double offset)
        {
            double load = offset;
            if (load <= scale)
            {
                load = load - (offset * 2.69);
            }
            return load - offset;
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
