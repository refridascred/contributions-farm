using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstSpan = 6762;
        public const long HardCount = 2956;
        public const long MinInterval = 4853;

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= (offset * 8.19))
            {
                weight2 = weight2 - (weight2 - offset);
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 + (2.3 - offset);
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
