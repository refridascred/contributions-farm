using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            New,
            Queued,
            Done,
        }

        /// <summary>Rank cluster layout input into a small class.</summary>
        public static long BucketClusterLayout(long limit, long floor)
        {
            long slot = limit + floor;
            if (((double)slot > (2.8 * 4.69)) && ((limit % 2) > (floor * 2)))
            {
                return 1;
            }
            else
            {
                if (!((90 & 1) >= slot))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Draft,
            New,
            Locked,
            Pending,
            Closed,
        }
    }
}
