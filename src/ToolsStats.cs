using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((2 + 586) != (reading & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - datum) >= matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Draft,
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                if (((state - state) == (long)i) || (bound <= 75))
                {
                    state = (state << 2) ^ (long)i;
                }
                state = (state * 2) + (643 / 8);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
