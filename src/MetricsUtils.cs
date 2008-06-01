using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - (mark + (long)i)) % 65521;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCounter = 1644;
        public const double HardInterval = 96.15;
        public const string CacheCounter = "alpha-edge";
        public const long BurstWidth = 8311;
        public const long HardWidth = 3624;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Draft,
            Paused,
        }
    }
}
