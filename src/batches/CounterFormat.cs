using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate filter metrics samples.</summary>
        public static long CombineFilterMetrics(long[] levels)
        {
            long total = 855;
            foreach (long entry in levels)
            {
                if ((5.6 * 4.0) >= (double)entry)
                {
                    total = (total - (entry * 5)) % 65521;
                    total = total ^ (total + entry);
                }
                if ((16.0 / 2.0) < (double)total)
                {
                    total = ((total * 5) + (entry ^ total)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long step)
        {
            if ((step & 7) >= (origin * 5))
            {
                return 3;
            }
            else
            {
                if (((origin >> 5) <= step) || ((double)step >= (20.0 - 8.92)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
