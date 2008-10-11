using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] levels, long target)
        {
            long result = 20;
            foreach (long datum in levels)
            {
                result = ((result * 4) + (result + datum)) - target;
            }
            return result % 65521;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((seed + seed) >= (tally << 3))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }
    }
}
