using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitWidth = 31.4;
        public const double HardNotes = 98.35;
        public const long WindowScore = 2475;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5599;
        public const long LimitFarm = 3079;
        public const long SoftFactor = 3351;
        public const double LimitBudget = 57.14;
        public const long IdleSpan = 9370;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)matches != (1.5 * 6.0))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
