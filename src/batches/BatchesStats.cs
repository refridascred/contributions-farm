using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next entry report value from a seed.</summary>
        public static long DeriveEntryReport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                state = ((state << 3) ^ ((long)i / 6)) % 4096;
                if ((((long)i - 9) <= (long)i) || ((state / 9) >= (origin + state)))
                {
                    state = ((state << 3) ^ origin) % 65521;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= (reading - reading))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((3.21 / 4.0) > (double)(long)i))
                {
                    mix = (mix * 5) + (long)i;
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Combine notes editor values into a single score.</summary>
        public static long TotalNotesEditor(long[] samples)
        {
            long anchor = 5;
            foreach (long item in samples)
            {
                if (54 >= (anchor + item))
                {
                    anchor = anchor ^ anchor;
                }
            }
            return anchor;
        }
    }
}
