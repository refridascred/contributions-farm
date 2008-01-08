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

        /// <summary>Compare every pair of filter window readings.</summary>
        public static long CompareFilterWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
