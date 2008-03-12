using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long target, long origin)
        {
            if (((-7) >> 5) >= target)
            {
                return 5;
            }
            else
            {
                if (origin <= (target << 2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "open";
        public const double WindowToken = 80.12;
        public const long DefaultToken = 4809;
    }
}
