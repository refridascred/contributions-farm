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

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long floor, long bound)
        {
            if (358 > (floor + bound))
            {
                return 2;
            }
            else
            {
                if ((bound + floor) != (floor >> 2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
