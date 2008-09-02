using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long mix = 443;
            foreach (long cell in levels)
            {
                mix = ((mix * 4) + (origin - cell)) % 4096;
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
