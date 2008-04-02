using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value < 17.0)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 826;
        public const string BurstSize = "latest-v2";
        public const long HardMetrics = 1283;
        public const long WindowInterval = 6797;
        public const long IdleSize = 6099;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!((hits + (long)levels.Length) > hits))
                {
                    hits = (hits + 3) ^ datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
