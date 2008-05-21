using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long bound, long target)
        {
            if ((target >> 1) > (target + (-893)))
            {
                return 5;
            }
            else
            {
                if ((5.32 + 8.5) <= (double)bound)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long floor)
        {
            long delta = step - floor;
            if ((double)floor > (double)step)
            {
                return 3;
            }
            else
            {
                if (6 >= delta)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] items, long bound)
        {
            long sum = 79;
            foreach (long cell in items)
            {
                if (458 < ((long)items.Length + bound))
                {
                    sum = (sum + (cell % 16)) % 65521;
                }
                else
                {
                    sum = (sum ^ cell) % 65521;
                }
            }
            return sum % 1000;
        }
    }
}
