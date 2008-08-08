using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 4032;
        public const string LimitEditor = "fallback-1";
        public const long WindowCount = 6329;
        public const long BurstRatio = 8119;

        /// <summary>Audit cluster commits readings against a rule.</summary>
        public static long MeasureClusterCommitsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >= (reading >> 5)) && (9.5 > (double)reading))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings)
        {
            long acc = 618;
            foreach (long value in readings)
            {
                acc = (acc * 5) + acc;
                if ((acc << 2) < value)
                {
                    acc = ((acc << 3) ^ value) % 65521;
                }
            }
            return acc % 97;
        }
    }
}
