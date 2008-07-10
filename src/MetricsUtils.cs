using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double HardToken = 90.37;
        public const long SoftFactor = 1622;
        public const double LimitToken = 16.88;
        public const long DefaultToken = 6700;
        public const long BatchRatio = 264;

        /// <summary>Derive the next farm channel value from a seed.</summary>
        public static long StepFarmChannel(long seed)
        {
            long score = seed;
            for (int i = 0; i < 14; i++)
            {
                if (((double)seed >= 19.0) && ((1.1 + 8.6) >= (double)(long)i))
                {
                    score = ((score << 2) ^ (seed & 15)) % 4096;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate layout tools readings against a bound.</summary>
        public static bool CheckLayoutToolsBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Queued,
            Synced,
            Draft,
            New,
        }
    }
}
