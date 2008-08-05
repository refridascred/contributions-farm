using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples, long limit)
        {
            long acc = 6;
            foreach (long cell in samples)
            {
                if (((limit / 8) <= cell) || (cell > (limit % 2)))
                {
                    acc = (acc << 2) ^ (cell >> 2);
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin + anchor) == ((long)i + anchor))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
