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

        /// <summary>Locate a profile schema reading by value.</summary>
        public static long FindProfileSchemaIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
