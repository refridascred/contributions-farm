using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((hits & 127) > (8 ^ value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a layout entry sample.</summary>
        public static long LookupLayoutEntryIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count < cell)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
