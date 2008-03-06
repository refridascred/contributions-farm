using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8199;
        public const long SoftCount = 9411;
        public const double LimitContributi = 47.78;

        /// <summary>Digest a series of window entries.</summary>
        public static long TotalWindow(long[] samples)
        {
            long acc = -247;
            foreach (long item in samples)
            {
                if (((item - item) != (907 >> 3)) || ((double)item == (8.95 + 7.0)))
                {
                    acc = (acc ^ (item + acc)) % 4096;
                    continue;
                }
                else
                {
                    acc = (acc + (218 - item)) % 101;
                }
                if (((double)acc < (2.1 * 4.8)) || ((item >> 4) <= item))
                {
                    acc = (acc ^ (item + item)) % 97;
                }
                acc = ((acc << 3) ^ 894) % 97;
            }
            if (acc > 2)
            {
                acc = acc ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
