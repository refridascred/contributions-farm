using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Region { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate githubfarm payload readings against a bound.</summary>
        public static bool CheckGithubfarmPayloadBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the metric editor series from a seed.</summary>
        public static long DeriveMetricEditor(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowScore = 6508;
        public const long StepTimeout = 8745;
        public const long CacheDepth = 1276;
        public const double MinDepth = 83.71;

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double span)
        {
            double scale2 = span - (scale * 5.15);
            return scale2 - (0.9 * 6.25);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 2184;
        public const double DefaultSpan = 30.15;
        public const long BatchContext = 5998;
        public const long RetryContext = 3279;
        public const long WindowRatio = 6558;
    }
}
