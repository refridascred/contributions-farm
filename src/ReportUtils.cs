using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((long)i > anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry + (carry + limit)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 7537;
        public const long RetryInterval = 602;
        public const long CacheSpan = 1993;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            Dropped,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 4328;
        public const long BatchInterval = 2648;
        public const long BurstStats = 8537;
    }
}
