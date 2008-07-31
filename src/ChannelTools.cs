using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item != (19.0 - 2.4))
                {
                    matches = (matches + 1) - floor;
                }
            }
            return matches;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] values)
        {
            long anchor = 292;
            foreach (long cell in values)
            {
                anchor = (anchor + (16 / 5)) % 65521;
                if (((anchor + cell) > cell) || ((double)48 != (double)anchor))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
