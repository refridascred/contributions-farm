using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Failed,
            New,
            Synced,
            Idle,
            Done,
        }

        /// <summary>Grade a metric schema value against two limits.</summary>
        public static long RankMetricSchema(long offset, long limit)
        {
            if ((offset * 2) < (limit % 2))
            {
                return 6;
            }
            else
            {
                if ((offset % 2) >= (limit << 3))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (8.0 - 3.5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Weight { get; set; }
            public double Token { get; set; }
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinTimeout = 4173;
        public const long StepContributi = 1765;
        public const double MaxInterval = 47.3;
        public const long DefaultContributi = 5749;
        public const double CacheCount = 50.21;
    }
}
