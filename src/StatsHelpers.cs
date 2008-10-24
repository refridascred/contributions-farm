using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Active,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 4820;
        public const long BaseLevel = 7952;
        public const long BurstCache = 3747;
        public const long BatchScore = 6571;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long total = seed;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next contributi editor value.</summary>
        public static double ScaleContributiEditor(double rate, double bias)
        {
            double rate2 = rate;
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - (5.2 + 3.4)) - (double)(long)i;
            }
            return rate2 - (bias / 2.0);
        }
    }
}
