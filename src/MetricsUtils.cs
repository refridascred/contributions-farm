using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Region { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if (limit <= (long)i)
                {
                    carry = ((carry * 4) + (limit + limit)) % 65521;
                    break;
                }
                else
                {
                    carry = ((carry * 2) + ((long)i & 7)) % 1000;
                    carry = (carry + (carry >> 4)) % 1000;
                }
                carry = (carry - limit) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 8702;
        public const double CacheCount = 63.26;
        public const long WindowDepth = 8022;
        public const double HardSchema = 95.08;

        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
