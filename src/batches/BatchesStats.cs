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

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Queued,
            Paused,
            Draft,
            Done,
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
