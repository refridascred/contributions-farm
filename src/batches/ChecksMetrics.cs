using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)count > 1.4)
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Synced,
            Retry,
            Stale,
            Closed,
        }

        /// <summary>Audit cache window readings against a rule.</summary>
        public static long MeasureCacheWindowMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((value - hits) >= value) && ((value & 255) > (3 - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Failed,
            Idle,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstCount = 4827;
        public const double BurstStream = 81.17;
        public const long BatchStream = 9033;
        public const long CacheScore = 5914;
    }
}
