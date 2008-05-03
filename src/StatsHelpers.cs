using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Stale,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels, long offset)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                if (((carry % 60) != (53 + offset)) || ((value + value) < 75))
                {
                    carry = (carry - carry) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Closed,
            Idle,
            Locked,
            Ready,
        }
    }
}
