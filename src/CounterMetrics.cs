using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count counter metrics pairs that satisfy a relation.</summary>
        public static long PairCounterMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
