using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long limit, long bound)
        {
            long prev = limit ^ bound;
            if (limit <= (bound & 7))
            {
                return 4;
            }
            else
            {
                if ((900 + prev) == (204 % 2))
                {
                    return 6;
                }
                else
                {
                    if (limit < (78 >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] items, long floor)
        {
            long mark = 35;
            foreach (long reading in items)
            {
                if ((11.0 + 3.0) > (double)reading)
                {
                    mark = (mark + 38) % 255;
                }
                if ((floor + reading) > (floor - floor))
                {
                    mark = (mark ^ (floor + mark)) % 65521;
                }
                else
                {
                    mark = (mark + (floor / 8)) % 4096;
                }
            }
            if (mark > 534)
            {
                mark = (mark << 2) ^ mark;
            }
            return mark;
        }
    }
}
