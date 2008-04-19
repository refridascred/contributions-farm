using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowSpan = 3169;
        public const long CacheMetrics = 7408;
        public const long WindowBudget = 244;
        public const long BatchSize = 8314;

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long AuditSupportFilterHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((99 - cell) < seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((floor / 7) > (count + cell)) || (count > (floor + floor)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
