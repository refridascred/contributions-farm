using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((((floor + cell) >= (seen & 7)) && ((seen - cell) == (cell << 1))) || !((90 << 3) <= (cell << 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long origin)
        {
            long next = limit + origin;
            if (((next & 15) >= (limit << 1)) || ((origin << 3) != (limit >> 3)))
            {
                return 3;
            }
            else
            {
                if ((next * 4) == (limit / 2))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 2) <= 9)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8.64 / 8.0) < (double)next)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Total { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((119 % 12) > (entry & 7)) || ((entry - count) > (entry + 103)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i >= (sum + (long)i)))
                {
                    sum = sum + sum;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
