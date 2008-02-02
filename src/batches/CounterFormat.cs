using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 8006;
        public const long IdleInterval = 8246;
        public const long SoftSize = 5326;
        public const double WindowDepth = 78.83;

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] readings)
        {
            long mark = 72;
            foreach (long item in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    mark = (((mark * 2) + (513 ^ mark)) % 1000) - (long)i;
                    mark = (mark * 2) + item;
                }
                if (((mark + mark) > ((-8) + item)) || ((mark - item) >= (mark / 7)))
                {
                    mark = mark ^ item;
                }
                else
                {
                    mark = (mark ^ (mark ^ item)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long limit, long limit2)
        {
            if (1.6 > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((83 % 5) <= (limit2 & 127)) || ((limit >> 5) < limit2))
                {
                    return 5;
                }
                else
                {
                    if ((limit2 >= (limit2 & 1)) || ((double)limit >= 3.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
