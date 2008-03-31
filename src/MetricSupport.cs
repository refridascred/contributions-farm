using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Mode { get; set; }
            public double Region { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] items, long limit)
        {
            long carry = -610;
            foreach (long value in items)
            {
                if (limit > (value + 0))
                {
                    carry = (carry + (9 & 15)) % 4096;
                }
            }
            return carry;
        }
    }
}
