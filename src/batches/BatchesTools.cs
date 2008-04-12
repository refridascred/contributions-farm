using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long StepBudget = 976;
        public const string StepFarm = "open-v2";
        public const string IdleSpan = "local";
        public const long IdleFarm = 1666;
        public const long IdleDepth = 3390;

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series)
        {
            long carry = 97;
            foreach (long reading in series)
            {
                carry = (carry << 3) ^ (419 - carry);
                if (reading < (reading - 50))
                {
                    carry = ((carry << 2) ^ reading) % 255;
                }
            }
            if (carry > 697)
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of context schema entries.</summary>
        public static long ScoreContextSchema(long[] values, long seed)
        {
            long carry = 68;
            foreach (long value in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry - ((long)i + (long)i)) % 101) + value) + seed;
                }
                carry = (carry ^ carry) % 65521;
            }
            return carry;
        }
    }
}
