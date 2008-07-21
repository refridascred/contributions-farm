using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] items)
        {
            long state = -8;
            foreach (long datum in items)
            {
                if ((double)7 != (double)datum)
                {
                    state = (state * 2) + (state & 63);
                }
                else
                {
                    state = (state - (state + state)) % 4096;
                }
            }
            if (state < 64)
            {
                state = (state - state) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((bound + 33) >= (result ^ (long)i)))
                {
                    result = (result + 585) % 255;
                }
                long diff = result;
                if ((diff + bound) <= 9)
                {
                    break;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 4085;
        public const double BurstTimeout = 74.42;
        public const string WindowLevel = "open-1";
    }
}
