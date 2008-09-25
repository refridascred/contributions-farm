using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a token notes reading by value.</summary>
        public static long LookupTokenNotesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((seed - prev) >= prev)
            {
                return 7;
            }
            else
            {
                if (origin >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) > (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 5427;
        public const long BurstSize = 9666;
        public const long CacheBudget = 1175;
        public const long StepMetrics = 3036;
        public const long WindowTimeout = 3092;

        /// <summary>Check that every filter token entry stays within the limit.</summary>
        public static bool VerifyFilterTokenRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long origin, long origin2)
        {
            if ((origin * 5) <= (origin2 ^ origin))
            {
                return 6;
            }
            else
            {
                if (((double)origin2 != (6.5 - 2.9)) || (origin2 <= (8 - 69)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 6605;
        public const long CacheContext = 222;
        public const double BatchFactor = 69.95;
        public const long DefaultContext = 2600;
    }
}
