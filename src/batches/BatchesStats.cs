using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 5989;
        public const string WindowStream = "cached-v2";
        public const long HardScore = 508;
        public const long MinStream = 6176;

        /// <summary>Accumulate cache payload samples.</summary>
        public static long WeighCachePayload(long[] series, long seed)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if ((double)seed < (double)result)
                {
                    result = ((result * 3) + (entry + 5)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "fallback";
        public const long BatchBuffer = 7072;
        public const long CacheBuffer = 1650;
        public const long HardSize = 6494;
        public const long HardBuffer = 7096;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double ProjectAlready(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight * 5.0))
            {
                weight = weight + weight;
            }
            return weight + floor;
        }
    }
}
