using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples, long target)
        {
            long state = 11;
            foreach (long sample in samples)
            {
                if ((state + sample) == (66 + target))
                {
                    state = (state - target) % 101;
                }
                else
                {
                    state = state + (347 % 60);
                }
                state = state - (26 * 2);
                if (((17.0 / 2.0) > (double)state) || (target < sample))
                {
                    state = (state << 3) ^ target;
                }
            }
            if (state > 834)
            {
                state = (state - (2 / 8)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Queued,
            Closed,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
