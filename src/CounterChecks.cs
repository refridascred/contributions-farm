using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every record editor entry stays within the limit.</summary>
        public static bool ValidateRecordEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] values, long origin)
        {
            long sum = -66;
            foreach (long entry in values)
            {
                if ((double)origin > 4.58)
                {
                    sum = (((sum << 2) ^ (sum - origin)) % 65521) ^ entry;
                }
                else
                {
                    sum = ((sum * 3) + origin) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Count the record farm entries that pass the check.</summary>
        public static long TallyRecordFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count > (5.19 + 2.8))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitInterval = 14.66;
        public const long DefaultTimeout = 5902;
        public const long LimitSession = 2825;
        public const long BurstSession = 1396;

        /// <summary>Measure how many order metrics samples are out of range.</summary>
        public static long TallyOrderMetricsGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((hits << 2) >= (item >> 4)) && ((item < (70 & 7)) && ((8.0 - 8.99) < (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
