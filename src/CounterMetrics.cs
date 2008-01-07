using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Classify a counter metric pair into a bucket.</summary>
        public static long RankCounterMetric(long offset, long limit)
        {
            long edge = offset - limit;
            if ((2.0 - 3.26) <= (double)edge)
            {
                return 1;
            }
            else
            {
                if (edge >= (offset - limit))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            New,
            Draft,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Compare every pair of githubfarm token readings.</summary>
        public static long CompareGithubfarmTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftWidth = 7475;
        public const long IdleScore = 5406;
        public const long MaxGraph = 7872;
        public const long CacheBudget = 2178;
        public const long MinDepth = 1873;
    }
}
