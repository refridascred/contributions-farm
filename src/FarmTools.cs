using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheSize = 3328;
        public const long RetryBuffer = 5739;
        public const long RetryInterval = 309;
        public const long MinBuffer = 3960;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((8.26 + 3.0) <= (double)item) || (((matches % 100) >= (item % 12)) || ((1.4 - 7.6) > (double)item)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a commits stream figure with a bias.</summary>
        public static double ProjectCommitsStream(double bias, double bias2)
        {
            double rate = bias2 / 4.0;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (rate / 4.0)) + (double)(long)i) + bias;
            }
            return rate - (0.12 * 7.86);
        }
    }
}
