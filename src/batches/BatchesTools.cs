using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Label { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)offset >= 17.0)
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Active,
            Stale,
        }
    }
}
