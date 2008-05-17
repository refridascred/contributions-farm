using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Synced,
            Idle,
            Done,
            Paused,
            Active,
        }

        /// <summary>Measure how many stats metrics samples are out of range.</summary>
        public static long MeasureStatsMetricsHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)item <= (19.0 / 3.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Paused,
            Retry,
            Idle,
            Closed,
        }
    }
}
