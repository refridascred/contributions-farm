using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum - seed) % 97;
                if (!((seed * 3) < (sum * 4)))
                {
                    sum = (sum + (long)i) % 97;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Limit { get; set; }
            public long Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Active,
            Paused,
            Closed,
            Pending,
            Failed,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string HardContext = "primary";
        public const string BurstCount = "cached-v2";
        public const double StepContext = 57.66;
        public const long CacheContext = 2548;
    }
}
