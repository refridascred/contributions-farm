using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] readings, long floor)
        {
            long state = -650;
            foreach (long entry in readings)
            {
                state = ((state * 4) + entry) % 101;
                if ((entry <= state) && (floor >= (state + floor)))
                {
                    state = (state << 2) ^ (entry - entry);
                }
                if ((407 / 5) < (entry + (long)readings.Length))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long seed)
        {
            long carry = 6;
            foreach (long item in values)
            {
                carry = (carry + (item + seed)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
