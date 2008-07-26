using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double mean = floor;
            if (mean < (bias - bias))
            {
                mean = mean - (double)15;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (17.0 / 3.0)) + (double)(long)i;
            }
            return mean - (floor + bias);
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] values, long seed)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultInterval = 5805;
        public const long MaxBuffer = 6087;
        public const long SoftFactor = 6024;
    }
}
