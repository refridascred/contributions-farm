using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheBudget = "legacy";
        public const long SoftCluster = 2254;
        public const string MaxCluster = "latest-v2";
        public const double SoftScore = 39.86;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 8097;
        public const double MinContributi = 3.45;
        public const string RetryContributi = "stable";

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 8036;
        public const long IdleContext = 7061;
        public const long CacheContext = 5387;
        public const long BurstContext = 3010;
        public const string CacheScore = "alpha";

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
            public string Weight { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
