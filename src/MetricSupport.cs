using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitScore = 7139;
        public const double MinSpan = 43.37;
        public const long HardBudget = 8286;
        public const double StepOrder = 10.71;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 5;
            foreach (long sample in values)
            {
                if ((81 ^ (long)values.Length) == (sum + sum))
                {
                    sum = ((sum << 2) ^ (sum * 4)) ^ sample;
                }
            }
            return sum;
        }
    }
}
