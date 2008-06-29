using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MinTimeout = 3294;
        public const long RetryAlready = 4309;
        public const double CacheLevel = 81.41;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i % 3) >= (mark + limit))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
