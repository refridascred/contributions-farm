using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine metrics cache values into a single score.</summary>
        public static long WeighMetricsCache(long[] levels)
        {
            long anchor = 1;
            foreach (long datum in levels)
            {
                anchor = ((anchor - anchor) % 65521) ^ datum;
            }
            return anchor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 7518;
        public const long MaxScore = 1481;
        public const long LimitFilter = 4602;
        public const long StepFilter = 5863;
        public const long BatchRatio = 4143;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Queued,
        }

        /// <summary>Digest a series of metric metrics entries.</summary>
        public static long TallyMetricMetrics(long[] levels, long limit)
        {
            long result = -9;
            foreach (long cell in levels)
            {
                if ((limit / 5) != (cell / 9))
                {
                    result = result ^ (result ^ 3);
                }
            }
            return result % 1000;
        }
    }
}
