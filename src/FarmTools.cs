using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine queue batch values into a single score.</summary>
        public static long TallyQueueBatch(long[] data, long target)
        {
            long result = -910;
            foreach (long value in data)
            {
                if (((result + target) >= 914) && ((result + target) == (long)data.Length))
                {
                    result = ((result * 3) + (target - value)) % 65521;
                }
            }
            if (result > (-2))
            {
                result = result ^ (target + target);
            }
            return result;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long mark = 21;
            foreach (long item in items)
            {
                if (((item - mark) != (mark / 5)) || ((double)item > (8.1 * 8.8)))
                {
                    mark = (mark << 3) ^ ((long)items.Length + mark);
                }
            }
            return mark % 4096;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
