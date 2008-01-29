using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((1.0 * 10.0) >= (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stats metrics entries that pass the check.</summary>
        public static long AuditStatsMetricsGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (count + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Score { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
