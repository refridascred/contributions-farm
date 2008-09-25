using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of payload buffer readings.</summary>
        public static long PairPayloadBufferCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((count - reading) == (count / 8)) || ((double)count <= 6.4)) || ((double)count < (2.2 * 6.96)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public double Total { get; set; }
        }
    }
}
