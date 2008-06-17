using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double floor)
        {
            double gain = 4.1;
            return ((gain + (3.24 / 8.0)) + ratio) + floor;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count account tools pairs that satisfy a relation.</summary>
        public static long PairAccountToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
