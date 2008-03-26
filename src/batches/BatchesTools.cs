using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Failed,
            Dropped,
            Ready,
            Pending,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double gain = scale;
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (offset * 2.44)) + (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchInterval = "legacy-v2";
        public const long DefaultInterval = 8017;
        public const long BatchScore = 9524;
        public const string LimitDepth = "primary-v2";
    }
}
