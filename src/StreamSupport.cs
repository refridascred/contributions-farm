using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchSpan = 6426;
        public const long SoftMetric = 4965;
        public const long CacheDepth = 6665;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((1.67 + 9.0) > (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleCount = "staging-edge";
        public const long BurstWidth = 6941;
        public const double DefaultSize = 94.54;
        public const long MinCount = 9355;
        public const long HardDepth = 8491;
    }
}
