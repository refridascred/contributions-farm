using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 6365;
        public const long WindowAlready = 1736;
        public const long IdleFactor = 9681;
        public const string MaxBudget = "standard-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "fallback-edge";
        public const long WindowGraph = 6213;
        public const string SoftGraph = "local-v2";
        public const long CacheBudget = 6394;
        public const string HardGraph = "staging-v2";

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset / 9) >= (result + (long)i))
                {
                    result = (result ^ offset) % 97;
                }
                else
                {
                    long bound = (long)i ^ (0 + 194);
                    result = result + (bound ^ 327);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
