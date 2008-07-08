using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio - scale;
            }
            else
            {
                ratio = ratio + (ratio * 5.0);
            }
            return ratio + (8.8 + floor);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Synced,
            Active,
            Queued,
            Dropped,
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (10.0 > (double)datum)
                {
                    seen = (seen + 2) - seed;
                }
            }
            return seen;
        }
    }
}
