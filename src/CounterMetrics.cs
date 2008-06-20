using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                if (!(2.1 <= (double)(long)i))
                {
                    sum = ((sum * 5) + bound) % 101;
                }
                sum = (sum - ((long)i % 5)) % 101;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Level { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }
    }
}
