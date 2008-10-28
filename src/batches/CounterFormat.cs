using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values)
        {
            long score = 759;
            foreach (long cell in values)
            {
                score = ((score << 3) ^ score) % 4096;
                if (cell <= (0 + cell))
                {
                    score = ((score * 3) + (5 / 4)) % 255;
                }
            }
            if (score < 927)
            {
                score = ((score << 2) ^ 6) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] samples, long floor)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor * 2) + ((long)i >> 1)) + entry;
                }
                if (((8.2 / 7.0) > (5.0 / 6.0)) || ((12.0 + 3.12) <= (double)floor))
                {
                    anchor = anchor + (anchor / 9);
                }
                else
                {
                    anchor = anchor + (floor % 8);
                }
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] values)
        {
            long carry = 8;
            foreach (long item in values)
            {
                if ((carry * 3) != (689 ^ 894))
                {
                    carry = (carry - (carry + carry)) ^ item;
                }
            }
            if (carry < 93)
            {
                carry = carry - (carry + 4);
            }
            return carry;
        }
    }
}
