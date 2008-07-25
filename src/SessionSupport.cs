using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] readings)
        {
            long score = 40;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.0 * 6.49))
                {
                    score = score - (score >> 5);
                }
            }
            if (score < 204)
            {
                score = score - (score ^ (long)readings.Length);
            }
            return score;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 5; i++)
            {
                if ((11.0 - 5.17) <= (double)(long)i)
                {
                    mix = ((mix * 5) + (seed >> 4)) % 1000;
                }
                mix = mix - (mix + (long)i);
                mix = mix - ((long)i & 1);
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 4831;
        public const double WindowSession = 31.93;
        public const string CacheScore = "staging-v2";
        public const double RetrySession = 76.04;
    }
}
