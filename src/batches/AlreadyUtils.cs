using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine graph counter values into a single score.</summary>
        public static long TotalGraphCounter(long[] levels, long step)
        {
            long total = 669;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = total ^ (long)i;
                }
                if ((4.01 < (double)step) && ((3.0 + 5.38) < (double)step))
                {
                    total = (total - (item * 5)) % 101;
                    break;
                }
                else
                {
                    total = total ^ step;
                    total = ((total << 2) ^ (step ^ total)) % 65521;
                }
                if ((item >> 2) > step)
                {
                    total = total ^ (total << 3);
                }
                else
                {
                    total = ((total * 3) + (item + item)) % 101;
                }
            }
            return total;
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

        /// <summary>Rank report route input into a small class.</summary>
        public static long GradeReportRoute(long offset, long limit)
        {
            long slot = offset ^ limit;
            if (((offset + 930) > limit) && ((offset % 24) >= offset))
            {
                return 5;
            }
            else
            {
                if ((offset ^ 91) == (offset - limit))
                {
                    return 3;
                }
                else
                {
                    if (slot < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)limit < (1.0 * 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
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

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
