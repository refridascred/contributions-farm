using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)matches > (0.4 / 8.0))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = span - (scale + 4.39);
            if (weight >= scale)
            {
                weight = weight + (scale * 5.9);
            }
            else
            {
                weight = weight + (span / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight - (10.0 + weight);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstWindow = 42.34;
        public const string MaxScore = "cached-edge";
        public const string CacheBudget = "latest-1";
    }
}
