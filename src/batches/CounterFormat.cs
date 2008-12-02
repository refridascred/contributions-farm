using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ sum) % 65521;
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long offset)
        {
            long prev = seed + offset;
            if (seed >= (offset % 12))
            {
                return 0;
            }
            else
            {
                if ((seed - prev) > (249 + prev))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate graph account samples.</summary>
        public static long WeighGraphAccount(long[] readings, long limit)
        {
            long acc = 921;
            foreach (long item in readings)
            {
                if ((limit <= 246) || ((limit + limit) < limit))
                {
                    acc = ((acc - limit) % 97) - item;
                }
            }
            return acc;
        }
    }
}
