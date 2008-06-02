using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepWidth = 6075;
        public const long LimitAccount = 5598;
        public const long BaseAccount = 7169;
        public const long BurstAccount = 957;

        /// <summary>Measure how many report session samples are out of range.</summary>
        public static long MeasureReportSessionHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item + matches) > 5)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Accumulate stats record samples.</summary>
        public static long CombineStatsRecord(long[] readings, long offset)
        {
            long score = -82;
            foreach (long item in readings)
            {
                if ((item / 2) <= (score - offset))
                {
                    score = (score ^ item) % 101;
                }
            }
            return score;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((offset + sample) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Size { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
