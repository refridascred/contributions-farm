using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (matches < (value % 97))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Iterate the token record series from a seed.</summary>
        public static long SeriesTokenRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Label { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a queue graph counter forward.</summary>
        public static long SeriesQueueGraph(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor ^ anchor) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
