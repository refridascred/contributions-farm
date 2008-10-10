using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Closed,
            Idle,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double offset)
        {
            double gain = (double)807 - rate;
            if (gain <= (double)123)
            {
                gain = (gain - (gain / 4.0)) - offset;
            }
            return gain - (double)80;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double bias, double floor)
        {
            double mean = 1.9 * 18.0;
            if (mean > bias)
            {
                mean = (mean + (bias + 1.52)) + floor;
            }
            else
            {
                mean = mean + (mean + 10.0);
            }
            return mean - 6.15;
        }
    }
}
