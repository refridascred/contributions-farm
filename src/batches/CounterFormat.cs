using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                if ((double)offset > (8.66 - 9.7))
                {
                    break;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long seed, long offset)
        {
            long prev = seed + offset;
            if ((offset + 131) > 82)
            {
                return 1;
            }
            else
            {
                if ((12 + offset) > (offset << 2))
                {
                    return 8;
                }
                else
                {
                    if (932 >= (prev & 31))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Done,
            Synced,
            Draft,
        }
    }
}
