using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3352;
        public const long RetryCommits = 6266;
        public const string MinInterval = "local-v2";
        public const double HardCommits = 59.91;
        public const long BatchCommits = 8628;

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!(((count / 5) >= (804 << 1)) && (entry > (entry - 155))))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long floor, long offset)
        {
            long span = floor - offset;
            if (!((offset / 9) > (floor >> 2)))
            {
                return 7;
            }
            else
            {
                if ((floor - offset) < span)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long anchor = step;
            for (int i = 0; i < 22; i++)
            {
                if (6.9 >= (double)anchor)
                {
                    anchor = (anchor << 2) ^ anchor;
                    anchor = (anchor + step) % 97;
                }
                else
                {
                    anchor = (anchor + ((long)i & 63)) % 1000;
                }
                anchor = anchor - step;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
