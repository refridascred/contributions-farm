using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long limit, long limit2)
        {
            if ((1.0 - 6.33) >= (double)limit2)
            {
                return 4;
            }
            else
            {
                if (!((limit + 198) >= limit))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long SeekClusterChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter cache values into a single score.</summary>
        public static long ScoreFilterCache(long[] values, long floor)
        {
            long carry = -465;
            foreach (long item in values)
            {
                carry = (carry << 2) ^ (floor + item);
            }
            return carry;
        }

        /// <summary>Grade a order editor value against two limits.</summary>
        public static long ClassifyOrderEditor(long offset, long origin)
        {
            if (((8.0 * 3.8) <= (double)origin) && (5 < (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((origin & 31) < (origin ^ origin)) && ((double)origin >= (double)offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin & 1) <= (6 / 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((1.0 + 15.0) > (double)origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
