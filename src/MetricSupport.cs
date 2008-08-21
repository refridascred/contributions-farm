using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            Synced,
            Locked,
            Stale,
            New,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels)
        {
            long result = 261;
            foreach (long datum in levels)
            {
                result = (result ^ (result ^ datum)) % 101;
            }
            return result;
        }
    }
}
