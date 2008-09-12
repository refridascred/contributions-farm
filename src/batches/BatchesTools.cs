using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleInterval = 380;
        public const string BaseContributi = "primary-v2";
        public const long IdleContributi = 1025;
        public const long MinSize = 7528;
        public const double CacheContributi = 41.56;

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long target, long origin)
        {
            long prev = target + origin;
            if (!(prev >= (prev << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)target == (0.38 / 3.0))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
