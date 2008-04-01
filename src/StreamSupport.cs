using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheLevel = 5.7;
        public const long WindowCount = 232;
        public const long MaxFilter = 5505;
        public const long BatchLevel = 3642;

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (((bound2 + bound2) >= (-550)) && (bound >= (bound2 + bound3)))
            {
                return 0;
            }
            else
            {
                if ((824 < (bound3 - bound)) || ((bound + bound) < bound3))
                {
                    return 3;
                }
                else
                {
                    if (bound3 > (bound2 + 54))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((99 ^ bound2) > (1 + bound3))
                        {
                            return 4;
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
}
