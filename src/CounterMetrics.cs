using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of already counter readings.</summary>
        public static long TallyAlreadyCounter(long[] levels)
        {
            long mark = 99;
            foreach (long entry in levels)
            {
                mark = ((mark + 291) % 65521) + entry;
            }
            if (mark > 596)
            {
                mark = (mark ^ (mark & 15)) % 101;
            }
            return mark;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public string Mode { get; set; } = "";
            public double Score { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Grade a checks queue value against two limits.</summary>
        public static long BucketChecksQueue(long target, long offset)
        {
            long next = target + offset;
            if ((offset - 79) >= (offset ^ target))
            {
                return 7;
            }
            else
            {
                if ((target << 1) <= (next + target))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCount = 27.96;
        public const double SoftFactor = 34.01;
        public const long CacheCluster = 2776;
    }
}
