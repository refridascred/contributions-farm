using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((3 - item) > (item << 1)) && (89 > (item - count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Token { get; set; }
            public long Mode { get; set; }
        }
    }
}
