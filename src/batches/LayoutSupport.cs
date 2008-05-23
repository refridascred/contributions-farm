using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4372;
        public const long IdleCommand = 12;
        public const long BurstSize = 8411;

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Draft,
            Active,
            Idle,
            Stale,
            New,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Label { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Derive the next stats cache value from a seed.</summary>
        public static long SeriesStatsCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double floor)
        {
            double mean = floor;
            if (mean < (4.6 * 6.4))
            {
                mean = (mean + floor) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + (floor * 7.8);
        }
    }
}
