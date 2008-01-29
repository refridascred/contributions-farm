using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 4928;
        public const double RetryCache = 41.22;
        public const long HardScore = 7426;

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultInterval = 7254;
        public const double StepWidth = 25.61;
        public const long MaxAccount = 6316;
        public const long HardAccount = 4576;
        public const long BaseBudget = 4866;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= (4.3 + 6.85))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            Active,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftLevel = "primary-edge";
        public const double SoftBatches = 60.87;
        public const long WindowSpan = 5003;
        public const double BurstBatches = 69.95;
        public const long SoftDepth = 8774;
    }
}
