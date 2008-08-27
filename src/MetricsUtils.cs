using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double scale = 7.9;
            if (scale <= (scale * 7.9))
            {
                scale = (scale + weight) - span;
            }
            return scale - (8.0 - scale);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 3262;
        public const long RetryCluster = 106;
        public const double DefaultScore = 93.73;
        public const long StepCluster = 4539;
        public const long BurstInterval = 4898;

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }
    }
}
