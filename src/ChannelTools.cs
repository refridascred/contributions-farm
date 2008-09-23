using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + reading) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 3832;
        public const long BatchFarm = 4832;
        public const long BurstDepth = 5106;
        public const long HardDepth = 8717;
        public const long RetryFactor = 7249;

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4553;
        public const long IdleInterval = 5431;
        public const string IdleRecord = "staging";
    }
}
