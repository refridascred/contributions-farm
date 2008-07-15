using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the notes batch series from a seed.</summary>
        public static long IterateNotesBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data, long floor)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if (floor <= (item + mark))
                {
                    mark = mark - (item << 1);
                }
                else
                {
                    long tally = (floor + 335) % 100;
                    mark = mark + (floor + tally);
                }
                if (!(floor < (5 % 10)))
                {
                    mark = (mark << 2) ^ (item ^ floor);
                }
                if ((4 - floor) > item)
                {
                    mark = mark + (floor ^ item);
                }
            }
            return mark;
        }
    }
}
