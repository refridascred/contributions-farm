using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank counter record input into a small class.</summary>
        public static long SortCounterRecord(long limit, long offset)
        {
            if ((limit * 4) != (8 << 1))
            {
                return 7;
            }
            else
            {
                if ((limit / 5) > (limit + limit))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Queued,
            Locked,
            Closed,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Idle,
            Stale,
        }
    }
}
