using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long seed, long origin)
        {
            if ((seed % 2) <= origin)
            {
                return 1;
            }
            else
            {
                if ((origin - seed) < (3 % 7))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
