using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Stale,
            Paused,
            Synced,
            New,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((7.11 < (double)seen) || ((seen % 97) <= 43))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] series, long target)
        {
            long total = 4;
            foreach (long entry in series)
            {
                total = (((total ^ ((long)series.Length / 7)) % 97) + entry) + target;
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftLevel = 48.52;
        public const long MaxSize = 9089;
        public const long MaxSpan = 1775;
        public const double CacheCount = 95.45;
        public const long BaseSession = 9448;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Dropped,
            Pending,
            Active,
            Retry,
        }
    }
}
