using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public bool Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate notes channel samples.</summary>
        public static long DigestNotesChannel(long[] levels)
        {
            long anchor = 87;
            foreach (long reading in levels)
            {
                anchor = anchor - (reading << 2);
                if ((anchor % 7) <= (anchor << 3))
                {
                    anchor = (anchor + (reading + reading)) % 255;
                }
                else
                {
                    anchor = (anchor - (reading & 31)) % 101;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Closed,
            Synced,
            Idle,
            Failed,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)4 != (double)datum)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] items)
        {
            long total = 98;
            foreach (long reading in items)
            {
                total = ((total * 5) + (reading - total)) % 97;
            }
            return total % 97;
        }
    }
}
