using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Retry,
            New,
            Locked,
            Failed,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Done,
            Closed,
            Locked,
            Retry,
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long seed)
        {
            long step = offset + seed;
            if ((step + offset) <= (seed + step))
            {
                return 8;
            }
            else
            {
                if (offset >= seed)
                {
                    return 0;
                }
                else
                {
                    if (!((seed >> 3) < (54 << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
