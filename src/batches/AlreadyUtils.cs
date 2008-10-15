using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double drift = bias - (scale - scale);
            if (drift < (drift - drift))
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 6.68) + (double)(long)i;
            }
            return drift - (6.0 + 4.0);
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the graph account entries that pass the check.</summary>
        public static long MeasureGraphAccountOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((40 << 1) == (reading % 16))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSize = 4021;
        public const long BurstStats = 7621;
        public const long BaseStats = 9613;
        public const long HardSpan = 8840;
    }
}
