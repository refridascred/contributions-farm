using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a commits order sample.</summary>
        public static long LookupCommitsOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double LimitWidth = 29.24;
        public const long RetryRatio = 5090;
        public const long IdleOrder = 9836;
        public const long MinOrder = 441;

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Locked,
            Dropped,
            Retry,
            Closed,
            Active,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Idle,
            Active,
            Stale,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] readings)
        {
            long state = 593;
            foreach (long value in readings)
            {
                if (3 <= (state + value))
                {
                    state = (state + (value & 255)) % 4096;
                }
            }
            if (state > 2)
            {
                state = state + (state ^ 448);
            }
            return state % 65521;
        }
    }
}
