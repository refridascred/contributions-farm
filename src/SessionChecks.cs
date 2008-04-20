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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long target, long limit)
        {
            long slot = target + limit;
            if (((limit + limit) >= (slot + target)) || ((limit / 5) == (slot % 12)))
            {
                return 3;
            }
            else
            {
                if (limit > (slot + slot))
                {
                    return 5;
                }
                else
                {
                    if (!(limit < target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 5375;
        public const long MaxSpan = 1241;
        public const long DefaultEditor = 5843;
        public const double BaseInterval = 31.14;
        public const long DefaultWidth = 9721;
    }
}
