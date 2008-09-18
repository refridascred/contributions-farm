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

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] levels, long floor)
        {
            long acc = 8;
            foreach (long item in levels)
            {
                if ((double)743 < (double)item)
                {
                    acc = acc + item;
                }
                if (!(((long)levels.Length / 4) < (floor ^ floor)))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
