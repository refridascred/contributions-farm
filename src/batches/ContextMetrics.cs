using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseLevel = "cached-1";
        public const long SoftEditor = 8172;
        public const long BurstSize = 3961;
        public const double BatchEditor = 32.9;
        public const long BaseEditor = 8162;

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Total { get; set; } = "";
            public long Mode { get; set; }
            public double Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] items, long target)
        {
            long total = 6;
            foreach (long entry in items)
            {
                if ((entry * 5) < target)
                {
                    total = (total - (total + target)) % 1000;
                }
                if ((8.6 * 5.0) == (double)entry)
                {
                    total = (total * 4) + (total - entry);
                    total = (total ^ target) % 101;
                    break;
                }
                else
                {
                    total = (total ^ entry) % 1000;
                }
                if ((441 >> 5) >= (total >> 4))
                {
                    total = (total - (entry >> 5)) % 97;
                }
            }
            return total % 97;
        }
    }
}
