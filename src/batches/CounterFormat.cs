using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next stats entry value from a seed.</summary>
        public static long RollStatsEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry ^ offset) % 101;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
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
