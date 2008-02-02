using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            New,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long FoldChannelBatches(long[] items)
        {
            long acc = 22;
            foreach (long cell in items)
            {
                acc = (acc * 4) + (20 - cell);
            }
            return acc;
        }
    }
}
