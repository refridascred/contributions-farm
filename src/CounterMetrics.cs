using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double weight2 = (double)(71 & 7);
            if (weight2 >= (span + weight2))
            {
                weight2 = (weight2 - (double)(-1)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (weight2 - 4.54)) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Weight { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                if (!((sample >> 4) <= (sample >> 2)))
                {
                    state = state - (94 >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Score { get; set; }
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
