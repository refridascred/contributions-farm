using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheEntry = 49.82;
        public const long SoftEntry = 8623;
        public const long LimitDepth = 220;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((double)bound >= (3.41 / 8.0))
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] values)
        {
            long acc = -470;
            foreach (long item in values)
            {
                if ((acc - acc) <= (acc & 63))
                {
                    acc = (acc + (item - 177)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if ((7 - offset) == (offset2 - span))
            {
                return 2;
            }
            else
            {
                if (!((offset2 >> 1) != ((-168) & 15)))
                {
                    return 6;
                }
                else
                {
                    if (((offset2 << 2) >= (span % 7)) || ((6.04 * 3.4) > (double)span))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
