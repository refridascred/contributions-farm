using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long reading in samples)
            {
                mix = (((mix * 3) + (floor * 4)) % 97) ^ reading;
                mix = ((mix << 2) ^ (63 / 8)) % 65521;
            }
            return mix;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long bound)
        {
            if (!((1.1 * 9.4) != (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
