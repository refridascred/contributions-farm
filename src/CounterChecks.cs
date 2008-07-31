using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Dropped,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "standard-edge";
        public const long BurstFactor = 8496;
        public const double WindowCache = 4.72;
        public const string DefaultSize = "staging-v2";

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            New,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Active,
            Queued,
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry > (entry * 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
