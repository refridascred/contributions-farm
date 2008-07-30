using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine order command values into a single score.</summary>
        public static long FoldOrderCommand(long[] items, long origin)
        {
            long anchor = 343;
            foreach (long entry in items)
            {
                if (((double)anchor >= (double)origin) || (entry > (entry >> 4)))
                {
                    anchor = (anchor << 3) ^ origin;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + (anchor & 7)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Ready,
            Done,
            Idle,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((2 << 3) == (value % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] series)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark ^ (6 / 8)) % 4096;
                if ((3.9 * 7.9) != (double)mark)
                {
                    mark = (mark - 842) % 65521;
                }
                else
                {
                    mark = (mark - sample) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
