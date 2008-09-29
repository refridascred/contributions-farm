using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series, long bound)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if (!((reading - reading) < (reading & 3)))
                {
                    state = (state * 2) + (bound ^ state);
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long seed)
        {
            long mix = 18;
            foreach (long item in readings)
            {
                if (!((item + 91) < mix))
                {
                    mix = (mix + seed) % 255;
                }
            }
            return mix % 1000;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 3) ^ ((long)i + (long)i);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
