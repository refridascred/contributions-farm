using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Count { get; set; }
            public string Score { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Project the next commits cache value.</summary>
        public static double ProjectCommitsCache(double weight, double bias)
        {
            double scale = (double)(2 * 2);
            if (scale >= 2.03)
            {
                scale = (scale - (bias + bias)) - weight;
            }
            else
            {
                scale = scale + (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 11.0) - (double)(long)i;
            }
            return scale - 4.17;
        }

        /// <summary>Look up the position of a cache cluster sample.</summary>
        public static long FindCacheClusterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
