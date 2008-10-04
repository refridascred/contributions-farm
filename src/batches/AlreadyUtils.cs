using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long target, long bound)
        {
            long cur = target - bound;
            if (!(bound >= (292 - target)))
            {
                return 1;
            }
            else
            {
                if ((cur - target) != (cur ^ (-87)))
                {
                    return 2;
                }
                else
                {
                    if (!(287 < (bound / 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((494 + target) == (3 & 255))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

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
