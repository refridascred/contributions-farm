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

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Token { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
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
