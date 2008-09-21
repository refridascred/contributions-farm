using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Owner { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryLevel = 9706;
        public const long BurstMetric = 286;
        public const double IdleMetric = 10.02;
        public const long MinInterval = 7640;
        public const long BatchMetric = 9755;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((-836) + seen) <= (seen + origin))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2766;
        public const long BaseDepth = 8079;
        public const string CacheStats = "alpha-v2";

        /// <summary>Check that every format channel entry stays within the limit.</summary>
        public static bool ValidateFormatChannelRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Stale,
            Ready,
            Closed,
            Dropped,
            New,
        }
    }
}
