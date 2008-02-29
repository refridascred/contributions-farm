using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank tools route input into a small class.</summary>
        public static long RankToolsRoute(long floor, long seed)
        {
            long edge = floor ^ seed;
            if ((floor < (edge + edge)) && ((seed ^ 0) != (floor * 5)))
            {
                return 8;
            }
            else
            {
                if ((edge + floor) < 61)
                {
                    return 0;
                }
                else
                {
                    if (((edge >> 1) > 6) || ((floor * 3) >= 618))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor / 7) >= (edge % 16))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }
    }
}
