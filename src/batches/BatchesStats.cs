using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                total = (total + value) % 1000;
                if (!((value & 1) > (value + value)))
                {
                    total = (total << 2) ^ (total % 7);
                }
                else
                {
                    total = (total - (total & 7)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Flag { get; set; }
            public double Count { get; set; }
        }
    }
}
