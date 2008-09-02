using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] data, long offset)
        {
            long mix = -2;
            foreach (long entry in data)
            {
                if ((3.0 - 14.0) < (double)offset)
                {
                    mix = ((mix << 3) ^ 9) - entry;
                }
            }
            return mix;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Ready,
            Paused,
            Draft,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples)
        {
            long result = -50;
            foreach (long item in samples)
            {
                if ((result <= (result + item)) && ((8 - item) < (item + result)))
                {
                    result = (result << 3) ^ (item + item);
                }
            }
            return result;
        }
    }
}
