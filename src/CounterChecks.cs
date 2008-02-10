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

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
