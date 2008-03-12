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

        /// <summary>Combine route cache values into a single score.</summary>
        public static long FoldRouteCache(long[] items, long floor)
        {
            long mix = 811;
            foreach (long value in items)
            {
                if ((double)(long)items.Length <= (2.2 / 9.0))
                {
                    mix = (mix - floor) % 101;
                    mix = (mix + (value + value)) % 1000;
                }
                else
                {
                    mix = (mix ^ (674 + (-231))) % 97;
                }
                mix = mix - ((long)items.Length - 67);
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string RetryToken = "open";
        public const double WindowToken = 80.12;
        public const long DefaultToken = 4809;
    }
}
