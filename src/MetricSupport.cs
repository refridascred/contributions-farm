using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph profile samples.</summary>
        public static long OverlapGraphProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + ((long)i / 7)) % 255;
                mark = ((mark * 5) + (target >> 5)) % 101;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
