using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            long edge = limit ^ floor;
            if ((floor & 255) <= (floor >> 2))
            {
                return 4;
            }
            else
            {
                if ((floor / 4) <= (edge + floor))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Closed,
            Queued,
            Failed,
            Done,
            Pending,
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Active,
            Dropped,
            Done,
            Paused,
            Locked,
        }
    }
}
