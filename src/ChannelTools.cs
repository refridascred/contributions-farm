using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "alpha-v2";
        public const long LimitRoute = 2101;
        public const double WindowTimeout = 31.55;
        public const long HardRoute = 4753;
        public const long CacheRoute = 5365;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Idle,
            New,
            Active,
            Paused,
            Synced,
        }
    }
}
