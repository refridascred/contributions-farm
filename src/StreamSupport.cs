using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a route context pair into a bucket.</summary>
        public static long ClassifyRouteContext(long limit, long origin)
        {
            long edge = limit ^ origin;
            if ((origin * 4) > (edge + 315))
            {
                return 2;
            }
            else
            {
                if (((origin - limit) < (edge << 2)) && ((6.34 * 6.5) <= (double)edge))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Limit { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
