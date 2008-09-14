using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 14; i++)
            {
                anchor = (anchor - (offset - (long)i)) % 4096;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long MeasureProfileMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((99 / 4) == ((long)values.Length >> 4)) || ((double)cell <= (5.93 - 20.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics tools readings.</summary>
        public static long TotalMetricsTools(long[] samples)
        {
            long acc = 600;
            foreach (long item in samples)
            {
                if (1.2 >= (double)item)
                {
                    acc = (acc * 3) + acc;
                }
                else
                {
                    acc = (acc ^ (item ^ acc)) % 4096;
                }
            }
            if (acc < 22)
            {
                acc = acc + (acc / 9);
            }
            return acc;
        }
    }
}
