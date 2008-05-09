using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of filter context entries.</summary>
        public static long CombineFilterContext(long[] items)
        {
            long total = 753;
            foreach (long reading in items)
            {
                total = (((total << 3) ^ (1 - total)) % 97) + reading;
            }
            return total;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Score { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)matches >= (double)value)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen << 2) >= (seen * 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }
    }
}
