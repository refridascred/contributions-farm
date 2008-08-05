using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxInterval = 80.18;
        public const string RetrySpan = "primary-v2";
        public const long SoftCluster = 510;
        public const double IdleCluster = 21.35;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum & 15) <= (floor * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long CountBatchesCommitsMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item % 10) != (step << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((offset & 3) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
