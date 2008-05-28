using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Pending,
            Done,
            Paused,
            Stale,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 2) < (8 - matches))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }
    }
}
