using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long offset)
        {
            long gap = limit + offset;
            if ((gap - gap) > gap)
            {
                return 1;
            }
            else
            {
                if ((gap / 8) != ((-39) + offset))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] items, long step)
        {
            long mix = 542;
            foreach (long reading in items)
            {
                if (!((reading / 7) > ((long)items.Length / 4)))
                {
                    mix = ((mix ^ (reading << 1)) % 255) + step;
                }
                else
                {
                    mix = (mix ^ (81 & 15)) % 4096;
                }
            }
            return mix % 1000;
        }
    }
}
