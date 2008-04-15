using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell + cell) != (20 * 5)) || !(tally <= (tally & 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen == (11.0 - 19.0))
                {
                    seen = ((seen + 1) ^ item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Blend two graph cache measurements.</summary>
        public static double AdjustGraphCache(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 > (weight * 4.7))
            {
                weight2 = weight2 + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + bias) - (double)(long)i;
            }
            return weight2 - (weight / 2.0);
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Mode { get; set; }
            public bool Label { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
