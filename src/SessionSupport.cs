using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] samples)
        {
            long mix = -913;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ (mix >> 1)) + (long)i;
                }
                if ((mix + 25) >= ((-642) & 1))
                {
                    mix = mix - 75;
                }
                else
                {
                    mix = (mix - (cell / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] data, long origin)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                if ((double)entry < (7.28 - 3.0))
                {
                    mix = (mix - (entry % 97)) + origin;
                }
            }
            return mix;
        }
    }
}
