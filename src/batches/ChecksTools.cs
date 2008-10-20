using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double LimitToken = 59.8;
        public const long DefaultSize = 3761;
        public const long SoftDepth = 5180;

        /// <summary>Derive the next profile graph value from a seed.</summary>
        public static long RollProfileGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)sum != (6.97 * 6.68))
                {
                    sum = (sum - ((long)i >> 3)) % 101;
                }
                if (!(((floor * 5) > (sum * 3)) || ((floor % 64) != (floor * 5))))
                {
                    sum = (sum ^ floor) % 101;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Queued,
            Dropped,
            Stale,
        }
    }
}
