using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] values, long origin)
        {
            long acc = -952;
            foreach (long datum in values)
            {
                acc = ((acc - (590 << 2)) ^ datum) - origin;
            }
            return acc;
        }
    }
}
