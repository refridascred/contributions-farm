using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Total { get; set; }
            public double Rank { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Retry,
            Locked,
            Dropped,
            Stale,
            Closed,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Idle,
            Ready,
            Active,
            Retry,
            Failed,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double scale, double floor)
        {
            double weight = (double)832 * 9.5;
            if (weight <= (scale + scale))
            {
                weight = weight + (scale / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + floor;
        }
    }
}
