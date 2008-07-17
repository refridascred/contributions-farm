using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values, long origin)
        {
            long total = 78;
            foreach (long sample in values)
            {
                if ((total + sample) <= (sample >> 4))
                {
                    total = (total ^ (sample + total)) % 1000;
                }
                else
                {
                    total = (total ^ sample) % 65521;
                }
            }
            if (total < (-7))
            {
                total = (total ^ (origin * 4)) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((seed - value) == (value & 1)) && ((double)value >= (9.2 - 8.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
