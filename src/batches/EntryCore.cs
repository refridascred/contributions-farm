using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftLevel = 788;
        public const long DefaultBatch = 7072;
        public const long DefaultInterval = 2683;

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 3191;
        public const long CacheStats = 6670;
        public const long BurstScore = 6491;

        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values, long bound)
        {
            long sum = 53;
            foreach (long value in values)
            {
                sum = (sum - (sum % 97)) - bound;
                sum = sum - value;
                if ((double)sum == (10.0 + 3.0))
                {
                    break;
                }
            }
            if (sum < 707)
            {
                sum = (sum << 3) ^ (sum % 24);
            }
            return sum;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long bound, long origin)
        {
            if ((origin + origin) == (origin ^ origin))
            {
                return 4;
            }
            else
            {
                if ((origin - origin) >= origin)
                {
                    return 6;
                }
                else
                {
                    if ((double)origin < (8.0 * 11.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix + mix) % 97) - (long)i2;
                }
                if (origin >= ((long)i >> 5))
                {
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
