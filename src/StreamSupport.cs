using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinCommand = 5.5;
        public const long HardCommand = 3687;
        public const long MaxInterval = 5801;
        public const long BurstRatio = 1169;

        /// <summary>Scale a cluster buffer figure with a bias.</summary>
        public static double AdjustClusterBuffer(double scale, double floor)
        {
            double bias = (double)(608 + 28);
            if (bias >= 5.0)
            {
                bias = ((bias - (double)77) + scale) + floor;
            }
            else
            {
                bias = bias + (double)6;
            }
            return bias - (double)1;
        }
    }
}
