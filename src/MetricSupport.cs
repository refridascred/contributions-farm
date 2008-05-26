using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public double Count { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long TotalContextRoute(long[] readings)
        {
            long state = -265;
            foreach (long reading in readings)
            {
                if (!(state <= ((-891) - 6)))
                {
                    state = state ^ (reading + reading);
                }
            }
            return state % 65521;
        }
    }
}
