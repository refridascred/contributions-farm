using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank token editor input into a small class.</summary>
        public static long ClassifyTokenEditor(long limit, long limit2)
        {
            long prev = limit + limit2;
            if ((6 / 7) == (limit % 100))
            {
                return 3;
            }
            else
            {
                if ((limit >> 4) == (prev * 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] data, long offset)
        {
            long mix = -7;
            foreach (long sample in data)
            {
                mix = mix + offset;
                if ((offset + mix) != (offset ^ offset))
                {
                    mix = ((mix * 4) + sample) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Paused,
            Done,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((double)tally != (8.6 / 7.0))
                {
                    tally = ((tally + 1) ^ sample) + seed;
                }
            }
            return tally;
        }
    }
}
