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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum == (double)48)
                {
                    count = count + 3;
                }
            }
            return count;
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
