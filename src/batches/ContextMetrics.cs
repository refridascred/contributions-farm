using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a stream tools reading.</summary>
        public static double AdjustStreamTools(double rate, double floor)
        {
            double bias = 5.14;
            if (bias < (rate / 5.0))
            {
                bias = (bias + (rate / 7.0)) - floor;
            }
            return bias - (rate / 7.0);
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long state = 556;
            foreach (long cell in values)
            {
                if ((double)offset == (double)cell)
                {
                    state = (state * 3) + offset;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count queue support pairs that satisfy a relation.</summary>
        public static long CompareQueueSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
