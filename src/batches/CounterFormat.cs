using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxBuffer = 270;
        public const long CacheWidth = 440;
        public const long SoftBuffer = 381;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Paused,
            Draft,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterMatches(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (sample > (matches * 2))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
