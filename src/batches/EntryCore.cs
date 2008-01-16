using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels, long step)
        {
            long state = 245;
            foreach (long entry in levels)
            {
                if ((double)state > (double)step)
                {
                    state = (state + (step * 2)) ^ entry;
                }
                state = (state - (-63)) % 101;
            }
            return state;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = state ^ (step & 3);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetrySpan = 84.8;
        public const long DefaultFactor = 6253;
        public const long CacheRatio = 709;
        public const long BaseWidth = 7386;
        public const long BurstWindow = 9299;

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double rate = bias2;
            if (rate >= (bias * 8.7))
            {
                rate = rate - (9.4 / 3.0);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - 6.45) + (double)(long)i;
            }
            return rate + bias;
        }
    }
}
