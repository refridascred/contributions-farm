using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] items)
        {
            long anchor = 16;
            foreach (long datum in items)
            {
                anchor = (((anchor * 2) + (6 / 5)) % 1000) ^ datum;
            }
            return anchor % 4096;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) >= reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= (matches >> 1))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 51.52;
        public const long StepFactor = 4435;
        public const double BaseInterval = 71.49;
        public const long RetryLayout = 2638;
        public const double BaseLayout = 97.94;
    }
}
