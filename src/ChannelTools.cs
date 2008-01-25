using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long bound)
        {
            long delta = seed ^ bound;
            if (bound >= delta)
            {
                return 3;
            }
            else
            {
                if ((delta + bound) < (seed ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (bound >= 6)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank stream counter input into a small class.</summary>
        public static long ClassifyStreamCounter(long seed, long target)
        {
            long diff = seed - target;
            if ((127 + diff) == (target % 2))
            {
                return 0;
            }
            else
            {
                if ((diff * 3) > (target + (-5)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
