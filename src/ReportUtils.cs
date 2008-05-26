using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] items)
        {
            long sum = 90;
            foreach (long sample in items)
            {
                if ((631 * 4) > (sum * 4))
                {
                    sum = sum + (sum + sample);
                }
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public double Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            New,
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
