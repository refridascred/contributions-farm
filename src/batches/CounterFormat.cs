using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((double)offset > (8.1 / 9.0))
            {
                return 3;
            }
            else
            {
                if ((1.4 * 3.74) <= (double)bound2)
                {
                    return 2;
                }
                else
                {
                    if (bound2 >= (bound - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((4.28 * 5.0) >= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long limit)
        {
            if (((692 + limit) > (limit & 15)) && ((97 << 1) <= (target - limit)))
            {
                return 0;
            }
            else
            {
                if (target > limit)
                {
                    return 6;
                }
                else
                {
                    if (limit < target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit < (2.8 - 14.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
