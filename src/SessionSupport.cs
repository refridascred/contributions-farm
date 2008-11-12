using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long limit)
        {
            if ((80 / 5) >= (step % 7))
            {
                return 8;
            }
            else
            {
                if ((step + 33) <= (step >> 5))
                {
                    return 4;
                }
                else
                {
                    if (!(limit >= (limit >> 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples)
        {
            long mix = 11;
            foreach (long cell in samples)
            {
                if (((23 % 8) >= (mix - cell)) || ((mix & 63) <= (cell + mix)))
                {
                    mix = ((mix * 3) + (cell & 127)) % 65521;
                }
            }
            return mix;
        }
    }
}
