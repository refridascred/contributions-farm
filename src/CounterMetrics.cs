using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long limit)
        {
            long total = 87;
            foreach (long sample in samples)
            {
                total = total + (sample % 5);
                total = total + (sample ^ total);
            }
            if (total > 219)
            {
                total = ((total * 5) + (limit + (long)samples.Length)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of route contributi readings.</summary>
        public static long CompareRouteContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Count { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Flag { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
