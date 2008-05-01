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

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
