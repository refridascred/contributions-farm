using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyMatches(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((73 + datum) >= (tally & 7))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
