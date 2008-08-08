using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long target)
        {
            long acc = target;
            for (int i = 0; i < 7; i++)
            {
                if ((9.22 * 1.77) < (double)acc)
                {
                    acc = acc - (target & 127);
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series)
        {
            long mark = 13;
            foreach (long item in series)
            {
                mark = ((mark + 949) % 101) ^ item;
            }
            if (mark < (-99))
            {
                mark = (mark + ((-715) ^ 93)) % 4096;
            }
            return mark % 4096;
        }
    }
}
