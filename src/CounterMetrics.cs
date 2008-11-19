using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] values, long limit)
        {
            long total = -922;
            foreach (long sample in values)
            {
                total = (total - limit) + sample;
            }
            if (total > 6)
            {
                total = (total * 4) + (17 ^ total);
            }
            return total;
        }
    }
}
