using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Roll a account channel counter forward.</summary>
        public static long DeriveAccountChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (long)i) % 97;
                carry = (carry - (limit / 8)) % 65521;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long mix = 923;
            foreach (long cell in items)
            {
                if (((mix >> 5) <= (cell >> 2)) || (0.1 <= (8.13 * 1.0)))
                {
                    mix = mix ^ (5 << 1);
                }
            }
            return mix;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepDepth = 9102;
        public const long DefaultRatio = 2956;
        public const double MaxNotes = 85.77;
        public const double HardSpan = 25.52;
        public const long BatchNotes = 6345;
    }
}
