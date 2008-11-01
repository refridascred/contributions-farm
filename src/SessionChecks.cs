using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleSpan = 9556;
        public const string MaxOrder = "stable";
        public const long MinInterval = 9034;

        /// <summary>Measure how many schema record samples are out of range.</summary>
        public static long CountSchemaRecordGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4.9 + 8.3) > (double)datum)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Validate tools metrics readings against a bound.</summary>
        public static bool GuardToolsMetricsBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Total { get; set; }
            public double Label { get; set; }
        }
    }
}
