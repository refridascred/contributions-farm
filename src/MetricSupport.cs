using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            New,
            Dropped,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                if (!(6 > (limit + total)))
                {
                    total = ((total * 2) + limit) % 1000;
                }
                if ((limit + (long)i) > 511)
                {
                    total = ((total << 2) ^ (659 << 2)) % 101;
                }
                total = ((total << 2) ^ total) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
