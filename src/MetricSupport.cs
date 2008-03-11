using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] series)
        {
            long acc = -33;
            foreach (long value in series)
            {
                if ((acc - value) >= value)
                {
                    acc = (acc ^ 3) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Flag { get; set; }
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits < (2 / 9)) || ((double)hits <= (double)7))
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }
    }
}
