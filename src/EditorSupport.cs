using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Dropped,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long state = seed;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (932 + 3)) % 65521;
                state = state - (15 ^ 9);
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((26 + 457) >= seen)
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target / 6) > (value % 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
