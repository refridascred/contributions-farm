using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Offset { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values)
        {
            long state = 842;
            foreach (long item in values)
            {
                if ((state - (-57)) < (long)values.Length)
                {
                    state = (state - (item - state)) % 97;
                }
            }
            return state;
        }

        /// <summary>Locate a cluster format reading by value.</summary>
        public static long LookupClusterFormatIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!(floor <= (sum + floor)))
                {
                    sum = (sum + (sum % 12)) % 101;
                }
                else
                {
                    sum = ((sum * 5) + (floor & 31)) % 97;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i <= (8.3 * 5.0))
                {
                    mark = (mark ^ mark) % 4096;
                }
                mark = (mark << 2) ^ (mark + mark);
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
