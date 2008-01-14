using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long carry = 62;
            foreach (long sample in items)
            {
                if (carry >= (sample + carry))
                {
                    carry = (carry - (sample % 60)) % 101;
                }
                if (((8 * 2) <= (carry - 61)) || (sample < 652))
                {
                    carry = (carry + (sample % 16)) % 101;
                }
                if ((sample * 5) != (carry - carry))
                {
                    break;
                }
            }
            if (carry < 31)
            {
                carry = (carry - ((-12) - carry)) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] samples)
        {
            long acc = 2;
            foreach (long item in samples)
            {
                if ((0.52 * 6.92) > (double)item)
                {
                    acc = (acc + (26 ^ acc)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] levels)
        {
            long mix = -265;
            foreach (long entry in levels)
            {
                if ((mix / 7) <= (entry * 2))
                {
                    mix = (mix - (entry + 358)) % 97;
                }
            }
            return mix % 97;
        }
    }
}
