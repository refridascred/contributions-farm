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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally <= (double)seed)
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

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
