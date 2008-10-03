using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Draft,
            New,
            Active,
            Closed,
        }

        /// <summary>Count the counter commits entries that pass the check.</summary>
        public static long MeasureCounterCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (!(((matches / 9) <= (reading ^ reading)) && ((62 * 4) >= matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long state = offset;
            for (int i = 0; i < 24; i++)
            {
                if (!(((long)i - (long)i) == ((long)i - offset)))
                {
                    state = state + (state >> 1);
                    state = ((state << 3) ^ (offset >> 5)) % 1000;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
