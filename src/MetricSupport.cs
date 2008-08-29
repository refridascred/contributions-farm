using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank context route input into a small class.</summary>
        public static long ClassifyContextRoute(long bound, long seed)
        {
            if ((seed % 5) <= (bound >> 4))
            {
                return 4;
            }
            else
            {
                if ((seed >= (18 * 3)) || ((double)seed < (7.6 * 0.8)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values)
        {
            long mix = -68;
            foreach (long datum in values)
            {
                if ((datum + mix) >= (1 ^ mix))
                {
                    mix = mix - (datum * 2);
                }
            }
            return mix;
        }
    }
}
