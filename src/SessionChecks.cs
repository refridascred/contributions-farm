using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((687 - sample) < (matches << 3)))
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

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long origin)
        {
            long state = 4;
            foreach (long cell in items)
            {
                if ((double)state <= (double)8)
                {
                    state = ((state << 2) ^ origin) - cell;
                    state = (state + (657 / 4)) % 1000;
                }
                state = ((state << 2) ^ 945) % 255;
            }
            return state;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Draft,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 2367;
        public const long LimitCount = 7216;
        public const long BatchPayload = 5292;
    }
}
