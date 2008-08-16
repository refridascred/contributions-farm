using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the cluster profile entries that pass the check.</summary>
        public static long MeasureClusterProfileHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample + matches) == (sample - 81))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] readings)
        {
            long total = 641;
            foreach (long item in readings)
            {
                total = ((total + total) % 65521) - item;
            }
            return total;
        }
    }
}
