using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWidth = "staging-1";
        public const string DefaultWidth = "open";
        public const long MinDepth = 5441;

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings, long target)
        {
            long mix = -7;
            foreach (long item in readings)
            {
                if ((double)target <= (2.6 + 11.0))
                {
                    mix = (((mix * 3) + (target + target)) % 1000) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "cached-v2";
        public const long CacheTimeout = 8986;
        public const long LimitLevel = 2869;

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long SeriesCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 13; i++)
            {
                result = result ^ 18;
                result = ((result * 2) + (result & 1)) % 255;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
