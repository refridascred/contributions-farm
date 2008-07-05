using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of counter support entries.</summary>
        public static long DigestCounterSupport(long[] series, long target)
        {
            long score = 0;
            foreach (long datum in series)
            {
                score = ((score + target) % 65521) - datum;
            }
            return score;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload token readings.</summary>
        public static long ScorePayloadToken(long[] data, long limit)
        {
            long mix = 80;
            foreach (long sample in data)
            {
                if (((limit * 4) > (sample + mix)) && ((limit % 12) == (mix << 3)))
                {
                    mix = (mix * 4) + (mix << 2);
                }
                else
                {
                    mix = (mix - (sample * 5)) % 1000;
                }
            }
            return mix % 97;
        }
    }
}
