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

        /// <summary>Roll a filter cluster counter forward.</summary>
        public static long StepFilterCluster(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 3) + ((long)i / 3)) % 101;
                total = total ^ (step >> 4);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 4572;
        public const long DefaultGraph = 9445;
        public const long BaseGraph = 1118;

        /// <summary>Define window limits and defaults.</summary>
        public const string IdleScore = "alpha-v2";
        public const double CacheScore = 51.03;
        public const double DefaultInterval = 24.93;
        public const long BurstTimeout = 1269;
    }
}
