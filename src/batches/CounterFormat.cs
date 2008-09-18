using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                if (!((total + limit) <= limit))
                {
                    total = (total - (limit - (long)i)) % 4096;
                    continue;
                }
                total = (total ^ total) % 65521;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items)
        {
            long total = 398;
            foreach (long datum in items)
            {
                total = (total + (datum << 2)) % 4096;
            }
            return total;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((slot / 4) > (slot + 4))
            {
                return 2;
            }
            else
            {
                if ((double)limit <= (7.2 / 4.0))
                {
                    return 6;
                }
                else
                {
                    if ((slot & 255) > (slot % 100))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((92 & 63) < (limit2 % 16)) || ((limit + 55) > (limit - slot)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
