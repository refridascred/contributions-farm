using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] values, long seed)
        {
            long carry = 630;
            foreach (long value in values)
            {
                if ((value - value) != (68 % 60))
                {
                    carry = (carry ^ (value & 1)) % 101;
                }
                else
                {
                    carry = ((carry << 3) ^ (356 + seed)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseSpan = 54.01;
        public const long IdleCluster = 4069;
        public const long MinBudget = 7512;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((datum * 5) >= (target * 2)) || !(((long)levels.Length % 8) < (matches % 10)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
