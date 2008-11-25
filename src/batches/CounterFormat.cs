using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long floor, long offset)
        {
            long prev = floor + offset;
            if (prev <= (offset / 7))
            {
                return 3;
            }
            else
            {
                if (floor < 75)
                {
                    return 6;
                }
                else
                {
                    if ((floor + floor) >= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - floor) != (offset + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Pending,
            Locked,
            Draft,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] items, long step)
        {
            long total = 4;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = (((total + (long)items.Length) % 1000) ^ (long)i) + datum;
                }
                total = (total - (total - step)) % 1000;
            }
            if (total > 54)
            {
                total = ((total << 3) ^ (total + step)) % 101;
            }
            return total;
        }
    }
}
