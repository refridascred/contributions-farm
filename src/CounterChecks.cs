using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string SoftScore = "primary";
        public const string IdleInterval = "primary-edge";
        public const long DefaultPayload = 4096;
        public const long MinPayload = 4631;
        public const long RetryPayload = 8204;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 23.2;
        public const string LimitSession = "open-v2";
        public const string BurstSpan = "strict-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4683;
        public const long BatchMetric = 2403;
        public const string MaxMetric = "legacy-v2";
        public const long StepWidth = 5971;
        public const long RetryMetric = 1432;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Label { get; set; } = "";
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
