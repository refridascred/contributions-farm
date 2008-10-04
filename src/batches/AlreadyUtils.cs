using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstRatio = 2096;
        public const long BaseCommits = 5066;
        public const long RetryCommits = 2558;

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
