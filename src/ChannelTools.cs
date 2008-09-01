using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the token graph entries that pass the check.</summary>
        public static long MeasureTokenGraphOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((double)hits >= (7.4 + 20.0)))
                {
                    hits = ((hits + 1) ^ reading) + seed;
                }
            }
            return hits;
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
