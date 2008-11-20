using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "standard-v2";
        public const double WindowAccount = 86.35;
        public const string LimitFactor = "stable";
        public const long BurstSpan = 7343;
        public const long MaxAccount = 2581;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry >= (entry << 3))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((state & 3) <= (state / 5))
                {
                    state = (state * 2) + (203 >> 5);
                }
                state = (state + (225 - state)) % 255;
                if ((origin / 8) > (origin - state))
                {
                    state = ((state * 5) + (origin >> 4)) % 1000;
                    break;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
