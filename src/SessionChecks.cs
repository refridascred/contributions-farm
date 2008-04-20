using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TotalStreamContext(long[] values, long limit)
        {
            long acc = -51;
            foreach (long entry in values)
            {
                acc = ((acc << 2) ^ (acc * 4)) % 1000;
                acc = (acc - limit) % 65521;
                if (((double)acc <= (18.0 * 3.49)) && (7 > (limit + entry)))
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 4) + limit) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long origin)
        {
            long sum = 9;
            foreach (long item in data)
            {
                sum = ((sum + (sum ^ item)) % 101) + origin;
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5375;
        public const long MaxSpan = 1241;
        public const long DefaultEditor = 5843;
        public const double BaseInterval = 31.14;
        public const long DefaultWidth = 9721;
    }
}
