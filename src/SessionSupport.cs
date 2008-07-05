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

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
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
