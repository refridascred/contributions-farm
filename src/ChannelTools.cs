using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 18.63;
        public const long BatchLevel = 2406;
        public const double RetryFactor = 49.49;
        public const double HardLevel = 42.21;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
