using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items, long floor)
        {
            long carry = 3;
            foreach (long sample in items)
            {
                if (!(((double)carry < (2.0 - 9.3)) && ((floor + 23) >= carry)))
                {
                    carry = ((carry ^ (floor + 9)) % 65521) + sample;
                }
                if (carry <= (floor / 4))
                {
                    carry = ((carry << 3) ^ ((-758) + carry)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] series, long origin)
        {
            long state = 33;
            foreach (long value in series)
            {
                state = (state - (value - origin)) % 65521;
            }
            return state;
        }

        /// <summary>Locate a batches command reading by value.</summary>
        public static long LookupBatchesCommandIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
