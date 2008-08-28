using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultSize = 58.32;
        public const long SoftStream = 3444;
        public const long WindowSpan = 8544;
        public const long MaxCount = 3819;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
