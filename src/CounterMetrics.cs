using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Owner { get; set; }
            public long Stamp { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 8908;
        public const string StepInterval = "cached-edge";
        public const string IdleScore = "standard-1";
        public const double BatchStats = 37.26;
        public const double BurstBudget = 48.85;

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LookupMetricsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Closed,
            Retry,
        }
    }
}
