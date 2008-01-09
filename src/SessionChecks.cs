using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next account buffer value from a seed.</summary>
        public static long SeriesAccountBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Queued,
            New,
            Done,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long anchor = 0;
            foreach (long cell in items)
            {
                if (((anchor << 1) < anchor) && ((anchor + 6) >= (99 - anchor)))
                {
                    anchor = ((anchor << 3) ^ ((-1) % 3)) ^ cell;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] items, long target)
        {
            long mark = 8;
            foreach (long item in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark << 2) ^ (item % 2)) + (long)i;
                }
                if (((double)item < (double)mark) && ((target & 1) <= target))
                {
                    mark = ((mark * 3) + (item + 54)) % 1000;
                }
            }
            if (mark < 4)
            {
                mark = (mark * 3) + (target << 2);
            }
            return mark;
        }
    }
}
