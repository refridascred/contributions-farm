using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Locate a route stats reading by value.</summary>
        public static long FindRouteStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry - (seed * 4)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = (carry ^ (8 & 1)) ^ (long)i2;
                    carry = (carry << 3) ^ (carry << 3);
                }
                if (!((carry - seed) >= (carry + seed)))
                {
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 6; i++)
            {
                if (((long)i > (20 + mark)) || ((double)target == (double)mark))
                {
                    mark = (mark + (long)i) % 101;
                }
                mark = mark + (mark - target);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
