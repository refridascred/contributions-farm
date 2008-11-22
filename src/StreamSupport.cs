using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = (score ^ (score - offset)) - (long)i2;
                }
                score = ((score * 3) + (9 % 2)) % 65521;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] samples, long target)
        {
            long carry = 28;
            foreach (long sample in samples)
            {
                carry = ((carry - (sample - carry)) % 255) + target;
            }
            return carry;
        }
    }
}
