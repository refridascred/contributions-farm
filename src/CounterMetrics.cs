using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + (mix + seed)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] levels)
        {
            long score = -300;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (80 - 74)) + reading;
            }
            return score % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3953;
        public const double MaxReport = 5.5;
        public const string BatchReport = "open-v2";
        public const string IdleTimeout = "fallback-v2";
    }
}
