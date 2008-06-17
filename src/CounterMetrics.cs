using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Closed,
            Failed,
        }

        /// <summary>Validate checks schema readings against a bound.</summary>
        public static bool GuardChecksSchemaBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
