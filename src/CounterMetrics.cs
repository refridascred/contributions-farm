using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of session metrics readings.</summary>
        public static long CompareSessionMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (bound + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 101) ^ (long)i2;
                    sum = (sum * 4) + sum;
                }
                if (!!((sum + bound) >= bound))
                {
                    sum = ((sum << 3) ^ (bound - bound)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
