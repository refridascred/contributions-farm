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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
