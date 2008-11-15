using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitTimeout = 110;
        public const long CacheAlready = 5831;
        public const long CacheDepth = 2842;
        public const long MinAlready = 9780;

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items, long offset)
        {
            long anchor = 81;
            foreach (long datum in items)
            {
                if (((offset % 60) != (5 >> 4)) || (((-325) << 1) >= (anchor - offset)))
                {
                    anchor = ((anchor << 2) ^ (-70)) % 1000;
                }
                else
                {
                    anchor = anchor + (datum + anchor);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
