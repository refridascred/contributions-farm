using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftBatch = "cached-1";
        public const string CacheSize = "legacy-1";
        public const string BurstDepth = "legacy-edge";
        public const string IdleBatch = "cached-1";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Synced,
            New,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftDepth = 9797;
        public const string DefaultContributi = "staging-v2";
        public const long HardWidth = 5966;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long bound, long limit)
        {
            if (((8.47 * 5.91) > (double)bound) || (22 <= (bound - limit)))
            {
                return 0;
            }
            else
            {
                if ((double)705 < (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
