using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((floor >= ((-573) / 5)) || ((hits + datum) >= hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Done,
            Paused,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long acc = 384;
            foreach (long item in data)
            {
                if ((acc & 63) >= (item - acc))
                {
                    acc = ((acc * 2) + (item >> 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public long Region { get; set; }
        }
    }
}
