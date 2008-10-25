using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long offset2)
        {
            if ((offset * 4) >= offset2)
            {
                return 4;
            }
            else
            {
                if (((offset / 4) == ((-5) + offset2)) && (offset < (162 + offset2)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8679;
        public const long BaseRecord = 7896;
        public const string SoftSpan = "strict-1";
        public const double MinRecord = 38.21;
        public const long CacheRecord = 7865;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseRatio = "staging-v2";
        public const long RetryMetrics = 1994;
        public const long MinMetrics = 2457;
        public const long RetrySize = 7524;

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark << 2) ^ (mark + (long)i);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
