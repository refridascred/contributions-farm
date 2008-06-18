using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Draft,
            Done,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Done,
            Closed,
            Pending,
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count & 255) != (4 >> 2))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public long Owner { get; set; }
        }
    }
}
