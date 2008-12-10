using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long bound, long offset)
        {
            if (!((bound ^ bound) < (bound / 9)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) == (offset + bound))
                {
                    return 3;
                }
                else
                {
                    return 0;
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
