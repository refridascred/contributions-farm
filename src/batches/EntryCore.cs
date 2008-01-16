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

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long offset2)
        {
            if ((0 >> 2) < offset2)
            {
                return 0;
            }
            else
            {
                if ((3.5 * 9.4) > (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
