using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BurstSize = "latest-1";
        public const long HardGraph = 944;
        public const long CacheScore = 3727;
        public const string RetryRatio = "strict";
        public const long RetrySpan = 6365;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(hits <= (sample - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] samples)
        {
            long sum = 8;
            foreach (long item in samples)
            {
                sum = sum - (sum + item);
            }
            return sum % 4096;
        }
    }
}
