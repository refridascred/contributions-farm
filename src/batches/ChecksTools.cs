using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxTimeout = 73.69;
        public const long WindowSpan = 7942;
        public const long BatchGraph = 2416;
        public const double WindowLevel = 82.72;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Pending,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state + (long)i)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "alpha-v2";
        public const double CacheMetric = 87.28;
        public const string CacheWidth = "strict-v2";
        public const long BaseBudget = 4356;
    }
}
