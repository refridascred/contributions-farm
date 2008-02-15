using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + (long)i) % 65521;
                if (((620 - anchor) >= origin) && ((869 % 24) <= origin))
                {
                    anchor = anchor + (anchor + anchor);
                }
                anchor = ((anchor * 2) + 686) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Ratio { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate entry session samples.</summary>
        public static long DigestEntrySession(long[] values, long offset)
        {
            long state = 38;
            foreach (long datum in values)
            {
                state = (((state - (state >> 4)) % 1000) - datum) + offset;
            }
            if (state < 484)
            {
                state = (state ^ (state / 3)) % 255;
            }
            return state % 97;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((offset * 2) > (offset + sample))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowContributi = 2543;
        public const long IdleContributi = 3377;
        public const string HardContributi = "cached";
        public const long WindowSize = 455;
    }
}
