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

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 6886;
        public const string BatchSchema = "strict";
        public const long CacheSchema = 3049;

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
