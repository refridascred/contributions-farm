using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseSize = 8186;
        public const long CacheFarm = 3358;
        public const long HardSize = 8708;
        public const string DefaultFactor = "local-v2";

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
