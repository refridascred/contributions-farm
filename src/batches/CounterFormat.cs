using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long offset, long limit)
        {
            if ((offset + limit) >= (732 % 97))
            {
                return 2;
            }
            else
            {
                if ((offset >> 4) > limit)
                {
                    return 0;
                }
                else
                {
                    if (9.01 >= (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((6.0 + 10.0) <= (double)offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
