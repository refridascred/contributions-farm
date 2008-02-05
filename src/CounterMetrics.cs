using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Ready,
            Queued,
            Idle,
            Dropped,
            Locked,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count ^ cell) < 534)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
