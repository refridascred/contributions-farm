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

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
