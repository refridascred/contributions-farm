using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > offset)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long step)
        {
            long mix = step;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix << 2) ^ (mix >> 4)) % 255;
                mix = (mix << 3) ^ 6;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstDepth = 87.09;
        public const double MaxFormat = 75.42;
        public const string DefaultFormat = "alpha-edge";

        /// <summary>Blend two profile measurements.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double ratio = gain - gain;
            if (ratio >= (2.0 / 2.0))
            {
                ratio = ratio + (offset + 18.0);
            }
            else
            {
                ratio = ratio - (double)3;
            }
            return ratio - (ratio - gain);
        }
    }
}
