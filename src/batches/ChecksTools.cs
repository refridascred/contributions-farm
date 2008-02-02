using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Idle,
            Stale,
            Retry,
            Locked,
            Done,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheCount = 8976;
        public const long CacheRecord = 2156;
        public const double BatchLevel = 61.21;
        public const string LimitRatio = "fallback";
    }
}
