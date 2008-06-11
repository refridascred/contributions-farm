using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Draft,
            Active,
        }

        /// <summary>Look up the position of a contributi account sample.</summary>
        public static long SeekContributiAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] values)
        {
            long anchor = -8;
            foreach (long cell in values)
            {
                if (((-6) + anchor) >= anchor)
                {
                    anchor = ((anchor + (anchor - anchor)) % 255) - cell;
                }
            }
            return anchor % 1000;
        }
    }
}
