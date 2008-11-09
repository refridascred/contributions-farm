using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (count > (value << 1))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Count { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string SoftCounter = "stable-v2";
        public const double IdleCounter = 46.53;
        public const long RetryFactor = 2201;
        public const string MaxCounter = "staging-edge";
        public const string MaxScore = "latest-edge";

        /// <summary>Measure how many metric buffer samples are out of range.</summary>
        public static long AuditMetricBufferMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits >= (7.02 * 9.08))
                {
                    hits = ((hits + 2) + sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout batches samples are out of range.</summary>
        public static long CountLayoutBatchesHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((step >> 4) > ((long)readings.Length + step))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
