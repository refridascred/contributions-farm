using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "strict";
        public const long WindowChecks = 4611;
        public const long MaxDepth = 2477;
        public const long HardFactor = 2014;

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultScore = 7826;
        public const long BurstToken = 3439;
        public const long CacheToken = 5328;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches + matches) < matches)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
