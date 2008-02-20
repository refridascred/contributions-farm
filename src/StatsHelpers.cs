using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next token entry value from a seed.</summary>
        public static long SeriesTokenEntry(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                mix = (mix + step) % 65521;
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Failed,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 8424;
        public const double LimitCount = 61.35;
        public const long HardMetrics = 9994;

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardInterval = "primary";
        public const string IdleScore = "local";
        public const double CacheStats = 29.94;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileOutliers(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((4.8 - 7.76) <= (double)tally)
                {
                    tally = ((tally + 2) + entry) + limit;
                }
            }
            return tally;
        }
    }
}
