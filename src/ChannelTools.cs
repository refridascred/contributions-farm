using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Size { get; set; }
            public double Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long seed)
        {
            if (2.0 < (double)offset)
            {
                return 5;
            }
            else
            {
                if ((offset + (-2)) <= (seed + seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
