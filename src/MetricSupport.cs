using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowLevel = 3236;
        public const string LimitStream = "alpha-1";
        public const string BurstStream = "cached-edge";
        public const long IdleSize = 9986;
        public const long DefaultBudget = 9126;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum ^ (sum + sum)) % 1000;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
