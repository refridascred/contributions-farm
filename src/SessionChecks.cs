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

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8714;
        public const long HardLevel = 1672;
        public const long MinScore = 4117;

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
