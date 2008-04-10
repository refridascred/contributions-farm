using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 403;
        public const double CacheSize = 67.89;
        public const double BaseCluster = 53.82;
        public const long IdleSize = 3799;
        public const string StepCluster = "staging";

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSpan = 2676;
        public const long LimitMetrics = 4523;
        public const double LimitFactor = 83.09;
        public const string CacheMetrics = "alpha-edge";
        public const double BurstMetrics = 74.77;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!!((3.8 - 1.2) < (double)sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
