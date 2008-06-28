using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public double Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a metrics checks pair into a bucket.</summary>
        public static long BucketMetricsChecks(long offset, long bound)
        {
            if ((bound % 3) >= (bound & 63))
            {
                return 7;
            }
            else
            {
                if (!((double)bound == (5.6 * 12.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long SeriesStream(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((7.1 + 0.1) >= (double)total)
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
