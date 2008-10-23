using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of payload context readings.</summary>
        public static long TotalPayloadContext(long[] data)
        {
            long mix = 65;
            foreach (long cell in data)
            {
                if ((double)mix <= (11.0 + 2.2))
                {
                    mix = ((mix - (mix + (long)data.Length)) % 4096) + cell;
                }
            }
            return mix;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                if ((total + entry) > total)
                {
                    total = ((total ^ (total ^ total)) % 65521) + offset;
                }
            }
            return total;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Stamp { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits & 63) < datum)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
