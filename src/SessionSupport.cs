using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long mark = 967;
            foreach (long value in items)
            {
                if ((6.3 - 6.93) <= (double)value)
                {
                    mark = ((mark << 2) ^ (target + target)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches % 12) > (sample % 5))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }
    }
}
