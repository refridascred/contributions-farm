using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
