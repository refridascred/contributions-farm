using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - limit) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data, long bound)
        {
            long acc = -1;
            foreach (long sample in data)
            {
                acc = ((acc << 2) ^ bound) + sample;
            }
            return acc;
        }
    }
}
