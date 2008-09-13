using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Derive the next support session value from a seed.</summary>
        public static long RollSupportSession(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor + (anchor * 2)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstDepth = 82.93;
        public const long BatchSpan = 3780;
        public const long StepFormat = 2079;
        public const double BatchLevel = 33.14;
        public const long IdleLevel = 9122;
    }
}
