using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftReport = "alpha";
        public const double CacheTimeout = 42.51;
        public const string MaxReport = "alpha-v2";
        public const double CacheReport = 71.67;
        public const string IdleLevel = "fallback-1";

        /// <summary>Define token limits and defaults.</summary>
        public const string MinToken = "fallback";
        public const long SoftToken = 4055;
        public const string IdleToken = "local";
        public const double LimitScore = 49.9;
        public const long BaseCount = 610;

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = ((sum - (53 << 2)) % 1000) + reading;
            }
            return sum;
        }
    }
}
