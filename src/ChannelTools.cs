using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Locked,
            Active,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
