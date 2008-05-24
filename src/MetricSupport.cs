using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] items, long step)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                acc = (((acc << 3) ^ step) % 101) ^ cell;
            }
            if (acc < 77)
            {
                acc = acc - (acc + 5);
            }
            return acc % 4096;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
