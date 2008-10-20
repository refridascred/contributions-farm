using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long target)
        {
            if ((91 + bound) >= (bound << 3))
            {
                return 1;
            }
            else
            {
                if (!(target >= (bound * 4)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items)
        {
            long mark = 51;
            foreach (long value in items)
            {
                mark = (((mark * 3) + (mark + mark)) % 101) + value;
            }
            return mark % 65521;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Owner { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long origin)
        {
            long total = 98;
            foreach (long cell in series)
            {
                total = ((total + (343 ^ origin)) % 97) - cell;
            }
            return total % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Pending,
            Active,
            Draft,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
