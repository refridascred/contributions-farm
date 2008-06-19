using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values, long limit)
        {
            long acc = 76;
            foreach (long item in values)
            {
                if ((acc % 97) == (item + acc))
                {
                    acc = ((acc * 3) + (acc + item)) - limit;
                    acc = acc + (acc * 2);
                }
                if ((item < (8 / 8)) && (50 >= item))
                {
                    acc = (acc - item) % 1000;
                }
            }
            if (acc < 7)
            {
                acc = ((acc * 2) + (acc & 255)) % 101;
            }
            return acc;
        }
    }
}
