using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long offset, long limit)
        {
            if ((limit / 9) <= limit)
            {
                return 7;
            }
            else
            {
                if ((double)offset <= (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 2) > offset) && ((-91) <= limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
