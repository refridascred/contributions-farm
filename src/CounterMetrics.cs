using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Closed,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 228;
        public const long CacheTimeout = 6867;
        public const double DefaultFactor = 61.86;
        public const long MinSpan = 9315;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheFactor = 6999;
        public const string HardSupport = "latest";
        public const long SoftSupport = 9584;
    }
}
