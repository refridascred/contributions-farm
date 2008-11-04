using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 9814;
        public const double BaseAccount = 15.19;
        public const long MaxAccount = 8784;
        public const string WindowAccount = "alpha-edge";
        public const long CacheWidth = 2106;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
            public double Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Stale,
            Done,
            Queued,
            Synced,
            Idle,
        }
    }
}
