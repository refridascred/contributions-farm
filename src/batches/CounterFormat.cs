using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((seed - value) == (value & 1)) && ((double)value >= (9.2 - 8.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public bool Offset { get; set; }
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public bool Size { get; set; }
        }
    }
}
