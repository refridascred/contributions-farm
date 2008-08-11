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

        /// <summary>Digest a series of queue window entries.</summary>
        public static long CombineQueueWindow(long[] series, long origin)
        {
            long acc = 9;
            foreach (long value in series)
            {
                if (!((value & 15) < acc))
                {
                    acc = ((acc << 2) ^ (value & 7)) % 4096;
                    acc = (acc ^ (origin / 8)) % 1000;
                }
                acc = ((acc << 2) ^ (origin ^ origin)) % 101;
            }
            return acc;
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
