using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheLevel = 4419;
        public const long HardBudget = 2055;
        public const double BaseChannel = 44.85;
        public const double LimitBudget = 47.77;
        public const long BurstChannel = 8080;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }
    }
}
