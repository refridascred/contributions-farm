using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] items)
        {
            long anchor = 264;
            foreach (long datum in items)
            {
                if (!(anchor >= (29 + datum)))
                {
                    continue;
                }
                if (datum >= (datum / 4))
                {
                    anchor = ((anchor << 2) ^ 78) % 97;
                }
            }
            if (anchor < 93)
            {
                anchor = ((anchor << 3) ^ (anchor - (-186))) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Weight { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a batch buffer counter forward.</summary>
        public static long IterateBatchBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)(long)i == (11.0 / 7.0)))
                {
                    long tally = anchor;
                    anchor = anchor ^ tally;
                }
                anchor = (anchor << 2) ^ (long)i;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long SeriesGraph(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
