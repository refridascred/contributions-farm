using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Failed,
            Ready,
            Retry,
            Done,
        }

        /// <summary>Rank cluster cache input into a small class.</summary>
        public static long ClassifyClusterCache(long bound, long offset)
        {
            if ((double)offset >= (double)bound)
            {
                return 8;
            }
            else
            {
                if (bound <= (8 + 50))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Done,
            Idle,
            Ready,
        }
    }
}
