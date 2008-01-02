using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorBounds(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] items)
        {
            long acc = -30;
            foreach (long datum in items)
            {
                if ((datum > 72) || ((double)50 >= (double)acc))
                {
                    acc = ((acc * 5) + datum) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 20.7;
        public const string IdleBuffer = "latest-edge";
        public const long MinInterval = 8709;
        public const double HardBuffer = 71.37;
        public const long BurstBuffer = 299;

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double floor)
        {
            double mean = floor;
            if (mean > rate)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (rate * 7.0)) + (double)(long)i;
            }
            return mean - mean;
        }
    }
}
