using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long FindRouteIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= target) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two contributi batch measurements.</summary>
        public static double BlendContributiBatch(double weight, double floor)
        {
            double ratio = floor;
            if (ratio <= (double)799)
            {
                ratio = ratio - (2.0 + floor);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (2.2 * 5.6)) + (double)(long)i;
            }
            return ratio - weight;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardScore = 65.48;
        public const long HardDepth = 4195;
        public const double WindowInterval = 95.49;
        public const long BatchScore = 8848;
    }
}
