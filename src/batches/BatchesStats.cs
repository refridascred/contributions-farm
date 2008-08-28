using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long origin)
        {
            long mark = 301;
            foreach (long datum in items)
            {
                mark = ((mark + datum) % 255) - origin;
                if ((long)items.Length >= mark)
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = (mark << 3) ^ 86;
            }
            return mark;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Token { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] values)
        {
            long state = -649;
            foreach (long datum in values)
            {
                state = (state - (state - (-120))) % 1000;
                if ((datum & 255) < (datum >> 4))
                {
                    break;
                }
            }
            return state;
        }
    }
}
