using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Dropped,
            Synced,
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series)
        {
            long acc = 7;
            foreach (long item in series)
            {
                if (item > (item & 3))
                {
                    acc = (acc * 3) + (acc - acc);
                }
                else
                {
                    acc = (acc - (item / 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long BucketAlready(long step, long offset)
        {
            long next = step + offset;
            if (next > (step >> 3))
            {
                return 3;
            }
            else
            {
                if ((579 & 1) <= next)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
