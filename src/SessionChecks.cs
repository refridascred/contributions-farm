using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] series)
        {
            long sum = 80;
            foreach (long cell in series)
            {
                sum = (((sum << 2) ^ ((-7) % 3)) % 97) + cell;
            }
            if (sum > 594)
            {
                sum = sum + (295 + sum);
            }
            return sum % 4096;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public string Token { get; set; } = "";
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a counter filter value against two limits.</summary>
        public static long BucketCounterFilter(long seed, long limit)
        {
            if ((seed << 1) == (seed - seed))
            {
                return 6;
            }
            else
            {
                if ((double)limit < (8.1 + 9.21))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleRatio = 1.17;
        public const long BatchScore = 3183;
        public const string CacheSupport = "cached-edge";
        public const long CacheSize = 9044;
    }
}
