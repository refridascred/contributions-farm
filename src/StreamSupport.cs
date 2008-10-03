using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long target)
        {
            long offset = origin - target;
            if (offset < (offset - 3))
            {
                return 7;
            }
            else
            {
                if ((18.0 * 5.47) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
