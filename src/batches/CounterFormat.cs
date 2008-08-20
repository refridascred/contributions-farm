using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheWidth = 5145;
        public const long RetryBatch = 6618;
        public const double SoftWidth = 89.94;
        public const string MaxInterval = "stable-1";

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
