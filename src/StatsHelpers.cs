using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitLevel = 2522;
        public const long StepEntry = 8028;
        public const string RetryEntry = "alpha-v2";
        public const long BurstEntry = 5405;
        public const long StepScore = 3059;

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxFilter = 80.42;
        public const double DefaultRatio = 68.51;
        public const string CacheFilter = "standard-1";
        public const double RetryFilter = 14.04;
        public const long MinFilter = 8491;
    }
}
