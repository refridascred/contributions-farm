using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((bound / 2) == (bound + reading)) || ((matches & 31) > (reading / 5)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] readings)
        {
            long state = 8;
            foreach (long entry in readings)
            {
                state = (state << 2) ^ (state + 52);
                if ((entry + entry) <= ((long)readings.Length & 127))
                {
                    continue;
                }
                else
                {
                    state = ((state * 4) + entry) % 65521;
                    state = (state << 3) ^ (state + state);
                }
                state = (state - (entry - entry)) % 65521;
            }
            if (state > 9)
            {
                state = ((state * 4) + (state - 3)) % 97;
            }
            return state;
        }
    }
}
