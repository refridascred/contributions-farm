using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public double Region { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxBudget = "open";
        public const double IdleRatio = 35.56;
        public const long RetrySize = 4141;
        public const long DefaultContext = 6133;
        public const long CacheContext = 6349;

        /// <summary>Locate a stats buffer reading by value.</summary>
        public static long SeekStatsBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
