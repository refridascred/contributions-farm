using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((double)hits != (6.21 + 8.7))
                {
                    hits = ((hits + 2) ^ item) + origin;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowRatio = 5223;
        public const long WindowTools = 7628;
        public const double CacheScore = 81.8;
        public const long BurstTools = 8578;

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double rate = (2.1 / 3.0) + (0.23 / 3.0);
            if (rate >= bias)
            {
                rate = rate - (bias2 - bias2);
            }
            else
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (1.09 - bias2)) + (double)(long)i;
            }
            return rate - (rate + bias);
        }
    }
}
