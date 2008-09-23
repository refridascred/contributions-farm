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

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 1815;
        public const long MinScore = 9920;
        public const long BurstDepth = 9049;
        public const string IdleRatio = "cached-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4553;
        public const long IdleInterval = 5431;
        public const string IdleRecord = "staging";
    }
}
