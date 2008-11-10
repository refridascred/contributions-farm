using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Size { get; set; }
            public string Owner { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long offset, long step)
        {
            if ((step & 63) == (step << 2))
            {
                return 6;
            }
            else
            {
                if (((19.0 * 2.4) >= (double)step) && ((581 - offset) <= (927 ^ step)))
                {
                    return 7;
                }
                else
                {
                    if ((double)step >= (5.1 + 3.4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches >= (matches >> 4))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)origin > (8.68 / 7.0))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
