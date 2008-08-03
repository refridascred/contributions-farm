using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series)
        {
            long mark = 96;
            foreach (long reading in series)
            {
                if ((double)reading != (18.0 / 9.0))
                {
                    mark = mark + ((-44) * 4);
                }
                else
                {
                    mark = ((mark * 2) + (reading + reading)) % 97;
                }
                mark = ((mark * 3) + (reading ^ mark)) % 4096;
                mark = (mark * 3) + (mark % 100);
            }
            if (mark < 71)
            {
                mark = (mark + (mark << 1)) % 4096;
            }
            return mark;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ bound) % 101;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
