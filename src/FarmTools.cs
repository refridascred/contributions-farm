using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long SeriesEntry(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    acc = ((acc * 4) + origin) ^ (long)i2;
                    acc = acc - acc;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
