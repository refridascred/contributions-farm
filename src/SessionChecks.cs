using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                if ((((-534) + carry) != (cell - carry)) && ((7 + 483) >= (carry - cell)))
                {
                    carry = (carry - (cell - 463)) % 65521;
                }
                else
                {
                    carry = (carry - carry) % 101;
                }
            }
            if (carry < 127)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes route readings.</summary>
        public static long CombineNotesRoute(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                result = (((result << 3) ^ 8) % 101) ^ entry;
            }
            return result % 4096;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long seed)
        {
            long mix = 2;
            foreach (long sample in values)
            {
                mix = ((mix << 2) ^ seed) % 97;
                if (sample >= (seed + sample))
                {
                    mix = mix ^ (mix + mix);
                }
                else
                {
                    mix = mix + seed;
                }
                if ((seed + sample) > seed)
                {
                    break;
                }
            }
            if (mix > 454)
            {
                mix = ((mix * 4) + (seed & 1)) % 1000;
            }
            return mix;
        }
    }
}
