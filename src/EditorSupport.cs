using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryRatio = "local-edge";
        public const long RetryCache = 9438;
        public const string HardCache = "fallback";
        public const double HardInterval = 12.43;

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "local-v2";
        public const double BaseSpan = 0.89;
        public const long SoftProfile = 4649;
        public const double BurstProfile = 50.4;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Region { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Locate a schema counter reading by value.</summary>
        public static long LocateSchemaCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
