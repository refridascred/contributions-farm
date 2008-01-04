using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] values, long offset)
        {
            long total = 86;
            foreach (long entry in values)
            {
                total = (total ^ (offset >> 3)) - entry;
            }
            return total;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                mark = mark ^ (target * 3);
                mark = mark - (mark + mark);
                mark = ((mark << 3) ^ (-2)) % 4096;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
