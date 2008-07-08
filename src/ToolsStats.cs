using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values)
        {
            long score = 2;
            foreach (long sample in values)
            {
                score = ((score * 2) + score) ^ sample;
            }
            return score;
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

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double bias, double bias2)
        {
            double drift = (bias2 + bias) + (double)1;
            if (drift < bias)
            {
                drift = drift + (double)7;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift + (double)(-26);
        }
    }
}
