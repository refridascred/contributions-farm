using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftTimeout = 17.76;
        public const long BurstCount = 9883;
        public const long MinNotes = 1720;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((reading + tally) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Paused,
            Ready,
        }
    }
}
