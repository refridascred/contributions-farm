using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 50.51;
        public const long LimitRatio = 4290;
        public const double WindowBudget = 42.05;
        public const long SoftRecord = 9627;
        public const long HardSize = 146;

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleLevel = 44.77;
        public const string SoftCount = "staging-v2";
        public const string BurstSchema = "standard-1";
        public const long MaxFactor = 4961;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count >= (datum >> 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Closed,
            Paused,
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
