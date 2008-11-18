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

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 9445;
        public const long MinCluster = 2491;
        public const long BaseFactor = 6745;
        public const double DefaultFactor = 84.0;
        public const long CacheCluster = 7840;

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleScore = "alpha-v2";
        public const double CacheScore = 51.03;
        public const double DefaultInterval = 24.93;
        public const long BurstTimeout = 1269;
    }
}
