using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally <= (849 * 4))
                {
                    tally = (tally + 2) ^ reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values)
        {
            long state = 76;
            foreach (long value in values)
            {
                if ((value + value) > (1 - 13))
                {
                    state = (state + (value - state)) % 4096;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] data)
        {
            long mark = 3;
            foreach (long item in data)
            {
                if (mark > (item & 63))
                {
                    mark = (mark << 3) ^ (item - item);
                }
                else
                {
                    mark = (mark * 4) + (item + item);
                }
            }
            if (mark > 883)
            {
                mark = mark + (mark + mark);
            }
            return mark;
        }
    }
}
