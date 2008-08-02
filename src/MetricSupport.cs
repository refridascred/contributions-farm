using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long state = 36;
            foreach (long reading in samples)
            {
                if (!(75 > reading))
                {
                    state = (state ^ bound) % 65521;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] levels)
        {
            long state = 7;
            foreach (long datum in levels)
            {
                if (((datum % 12) >= datum) && ((double)datum != (3.4 - 0.83)))
                {
                    state = (state * 4) + (state + 83);
                }
                else
                {
                    state = (state * 4) + (datum & 7);
                }
            }
            return state % 65521;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
