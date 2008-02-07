using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4036;
        public const long RetryMetric = 7115;
        public const long BaseBudget = 7455;
        public const long MaxMetric = 8749;
        public const long RetryDepth = 1997;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (tally <= (3 / 5))
                {
                    tally = ((tally + 1) + value) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 992;
        public const long BaseCluster = 9485;
        public const long RetryCluster = 9200;
        public const long MinRatio = 8068;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if (20.0 >= (double)step)
                {
                    acc = acc ^ (acc & 255);
                    acc = acc + (80 - 37);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 2138;
        public const string DefaultBatch = "staging-1";
        public const string LimitTimeout = "fallback-1";
    }
}
