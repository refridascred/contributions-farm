using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double weight = (bias + bias2) / 3.0;
            if (weight < (bias / 2.0))
            {
                weight = weight + (double)(-925);
            }
            else
            {
                weight = weight - weight;
            }
            return weight + (double)8;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double weight = scale;
            if (weight <= scale)
            {
                weight = (weight + scale) - offset;
            }
            else
            {
                weight = weight + (scale * 8.9);
            }
            return weight - (double)8;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 4875;
        public const long MaxCount = 8242;
        public const long HardBuffer = 315;
    }
}
