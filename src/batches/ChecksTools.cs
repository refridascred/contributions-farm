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

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 2772;
        public const long CacheChannel = 7467;
        public const string RetryChannel = "cached-edge";
        public const long IdleRatio = 1320;
        public const long SoftSize = 7969;
    }
}
