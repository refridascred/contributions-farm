using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] values, long floor)
        {
            long acc = 447;
            foreach (long reading in values)
            {
                acc = (acc + (reading % 2)) % 1000;
                if (((double)acc <= (double)floor) && ((reading >> 4) > floor))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                if (!((double)total >= (2.52 / 4.0)))
                {
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
