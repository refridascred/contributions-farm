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

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 893;
        public const long LimitLevel = 2333;
        public const long WindowAccount = 8344;
        public const long RetryFactor = 7766;
        public const double HardBudget = 22.41;

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
