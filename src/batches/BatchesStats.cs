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

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample % 64) <= (offset ^ matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
