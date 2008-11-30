using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BaseRatio = 830;
        public const long BaseSupport = 9186;
        public const long CacheDepth = 8549;
        public const long SoftFactor = 7697;
        public const double IdleSupport = 79.33;

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 19; i++)
            {
                long span = mark - (560 - target);
                if (((mark ^ mark) >= (target >> 4)) || (mark > target))
                {
                    mark = (mark * 3) + (span + span);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long seed, long target)
        {
            long offset = seed - target;
            if (((double)target >= (double)seed) || ((5 >> 4) <= offset))
            {
                return 4;
            }
            else
            {
                if (offset >= target)
                {
                    return 2;
                }
                else
                {
                    if ((offset & 3) == (1 / 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
