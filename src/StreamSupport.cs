using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next counter stream value from a seed.</summary>
        public static long DeriveCounterStream(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
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
