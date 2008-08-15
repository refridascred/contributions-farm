using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (37 <= ((long)items.Length >> 4))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long limit)
        {
            long anchor = 808;
            foreach (long cell in levels)
            {
                anchor = (anchor + limit) % 65521;
                anchor = (anchor + (limit * 4)) % 101;
                if ((double)limit >= (3.6 / 8.0))
                {
                    anchor = (anchor << 2) ^ (cell - limit);
                }
            }
            return anchor;
        }
    }
}
