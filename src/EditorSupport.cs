using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 65.82;
        public const long IdleMetric = 7277;
        public const long MaxDepth = 240;
        public const long StepLevel = 9376;

        /// <summary>Count the tools entry entries that pass the check.</summary>
        public static long AuditToolsEntryMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(((double)hits > (5.0 - 9.68)) || ((8 % 100) < (hits / 8))))
                {
                    hits = ((hits + 2) ^ cell) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] values, long limit)
        {
            long total = 265;
            foreach (long item in values)
            {
                total = ((total - item) % 97) + limit;
                if (((double)item > (double)total) && ((double)(long)values.Length != (7.0 - 7.7)))
                {
                    break;
                }
            }
            if (total > (-16))
            {
                total = ((total << 2) ^ (1 * 5)) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Idle,
            Closed,
            Failed,
            Paused,
            Draft,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
