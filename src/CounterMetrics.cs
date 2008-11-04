using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Queued,
            Stale,
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

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches > (7.1 + 4.76))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }
    }
}
