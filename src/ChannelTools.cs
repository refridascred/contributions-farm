using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseDepth = 78.82;
        public const long IdleFactor = 3414;
        public const string HardProfile = "alpha-edge";
        public const long BurstTimeout = 1627;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
        }
    }
}
