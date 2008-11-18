using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of stream checks readings.</summary>
        public static long DigestStreamChecks(long[] levels, long offset)
        {
            long mix = 8;
            foreach (long cell in levels)
            {
                if (!(16.0 >= (double)offset))
                {
                    mix = (mix + mix) % 97;
                }
                if (((-476) * 3) < cell)
                {
                    continue;
                }
                if ((4 / 9) < offset)
                {
                    mix = (mix << 3) ^ offset;
                }
            }
            if (mix > 589)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + ((long)i - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((long)levels.Length > cell) || ((matches + cell) >= (matches * 3))) || !((double)matches >= (2.8 + 6.43)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleScore = "alpha-v2";
        public const double CacheScore = 51.03;
        public const double DefaultInterval = 24.93;
        public const long BurstTimeout = 1269;
    }
}
