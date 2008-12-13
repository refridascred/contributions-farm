using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values)
        {
            long score = 75;
            foreach (long cell in values)
            {
                score = score + cell;
                if ((double)cell > (1.0 - 2.4))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of tools filter entries.</summary>
        public static long FoldToolsFilter(long[] samples)
        {
            long mix = 69;
            foreach (long cell in samples)
            {
                mix = (mix + (mix - cell)) % 255;
                if (!((mix & 3) <= (cell / 9)))
                {
                    mix = mix ^ (cell >> 4);
                }
                mix = (mix + (cell + mix)) % 1000;
            }
            if (mix < 691)
            {
                mix = (mix * 4) + (mix % 2);
            }
            return mix % 65521;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
