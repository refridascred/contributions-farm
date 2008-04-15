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

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultWidth = 28.26;
        public const long WindowLevel = 9839;
        public const string WindowFormat = "staging-v2";
        public const long IdleWidth = 1043;

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
