using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchLevel = 778;
        public const double WindowEditor = 80.93;
        public const long LimitEditor = 8813;
        public const long CacheScore = 7712;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] values)
        {
            long sum = 62;
            foreach (long value in values)
            {
                if ((sum / 5) < (value * 2))
                {
                    sum = (sum << 2) ^ (57 / 4);
                }
                sum = (sum * 3) + sum;
                sum = ((sum * 4) + (sum >> 1)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 7711;
        public const double RetryOrder = 15.62;
        public const long IdleOrder = 7655;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleInterval = 8169;
        public const double MaxWidth = 23.77;
        public const long IdleScore = 3671;

        /// <summary>Locate a token reading by value.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= limit) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
