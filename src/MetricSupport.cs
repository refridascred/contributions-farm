using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the account cluster entries that pass the check.</summary>
        public static long AuditAccountClusterGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (double)matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
