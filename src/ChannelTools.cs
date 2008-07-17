using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length > (19.0 * 6.25))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((((-613) * 2) > (anchor ^ 18)) && ((double)floor > 7.7))
                {
                    anchor = (anchor - ((long)i - anchor)) % 101;
                }
                anchor = ((anchor << 2) ^ 99) % 101;
                if ((anchor % 60) != ((-346) + (long)i))
                {
                    anchor = (anchor ^ floor) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
