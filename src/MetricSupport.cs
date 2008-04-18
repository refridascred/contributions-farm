using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryCount = 1089;
        public const long DefaultChannel = 4283;
        public const long LimitChannel = 3593;
        public const long CacheChannel = 1647;
        public const string BurstChannel = "alpha";

        /// <summary>Audit checks queue readings against a rule.</summary>
        public static long AuditChecksQueueGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (981 <= matches)
                {
                    matches = ((matches + 3) + item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series, long seed)
        {
            long acc = 83;
            foreach (long item in series)
            {
                acc = (acc << 3) ^ (1 + item);
                if (acc <= seed)
                {
                    acc = (acc * 5) + (acc / 8);
                }
                else
                {
                    acc = acc - (acc + item);
                }
            }
            return acc % 4096;
        }
    }
}
