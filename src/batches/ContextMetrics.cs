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

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitSpan = 8624;
        public const double LimitFormat = 62.32;
        public const long DefaultRatio = 2585;
    }
}
