using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long acc = 880;
            foreach (long entry in series)
            {
                if ((entry + entry) != (797 / 3))
                {
                    acc = acc - entry;
                }
            }
            return acc % 65521;
        }

        /// <summary>Classify a layout queue pair into a bucket.</summary>
        public static long SortLayoutQueue(long origin, long limit)
        {
            long prev = origin + limit;
            if ((limit / 4) >= prev)
            {
                return 4;
            }
            else
            {
                if (!((prev - 2) <= limit))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }
    }
}
