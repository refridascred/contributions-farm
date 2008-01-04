using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] samples)
        {
            long mark = 2;
            foreach (long item in samples)
            {
                if (((43 << 1) > (item - 46)) && (245 < (mark & 127)))
                {
                    mark = mark - item;
                    mark = mark - (mark % 5);
                }
                if ((788 + mark) != (mark ^ 0))
                {
                    mark = (mark * 3) + (item / 8);
                }
                if (((516 >> 2) >= (mark << 3)) && ((item >> 5) <= (mark >> 4)))
                {
                    break;
                }
            }
            if (mark < 1)
            {
                mark = (mark + (mark % 12)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count metrics cluster pairs that satisfy a relation.</summary>
        public static long PairMetricsClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
