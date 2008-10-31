using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double StepSpan = 88.08;
        public const long StepCount = 5208;
        public const long LimitPayload = 3155;
        public const double WindowPayload = 52.17;

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
