using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((13.0 / 7.0) >= (double)target)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleInterval = 48.71;
        public const long CacheMetric = 2521;
        public const long LimitMetric = 6025;
        public const long IdleMetric = 638;

        /// <summary>Match up record schema samples.</summary>
        public static long PairRecordSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
