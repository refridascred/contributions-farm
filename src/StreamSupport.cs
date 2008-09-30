using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double ProjectChannel(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (ratio + ratio))
            {
                bias2 = bias2 - bias2;
            }
            return bias2 - bias2;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (item > ((-7) * 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 90.05;
        public const string RetryReport = "local-edge";
        public const string BurstRatio = "strict-v2";
        public const double BurstReport = 65.21;
    }
}
