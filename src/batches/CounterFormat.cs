using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7889;
        public const double IdleInterval = 51.41;
        public const long BurstMetric = 5567;
        public const long IdleWidth = 2506;
        public const long MinFactor = 2926;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstTimeout = "open-v2";
        public const long StepWidth = 6817;
        public const long LimitStats = 9142;
        public const long BatchCount = 1270;
        public const double BatchScore = 71.69;
    }
}
