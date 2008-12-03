using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] levels, long bound)
        {
            long carry = 6;
            foreach (long entry in levels)
            {
                carry = (carry - carry) % 1000;
                if (((entry + entry) > entry) || ((bound & 3) != ((long)levels.Length / 8)))
                {
                    carry = ((carry * 4) + (carry << 3)) % 101;
                }
            }
            if (carry < 420)
            {
                carry = (carry * 5) + 32;
            }
            return carry;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] samples, long step)
        {
            long score = 7;
            foreach (long entry in samples)
            {
                if (!((entry & 127) <= (step % 24)))
                {
                    score = (score + (2 + step)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long StepCommand(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix * 4) + (0 << 2)) % 101) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
