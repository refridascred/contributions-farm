using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Queued,
            Retry,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((85 ^ cell) >= cell)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 2) ^ state;
                state = state + (950 >> 1);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
