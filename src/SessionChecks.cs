using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            if (((8.34 - 16.0) == (double)offset2) && (offset2 < (offset2 + offset)))
            {
                return 2;
            }
            else
            {
                if ((offset2 - offset2) < offset2)
                {
                    return 5;
                }
                else
                {
                    if ((offset2 << 1) == (offset & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((offset2 - offset) >= (offset2 << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long floor)
        {
            if ((double)limit >= (6.6 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((floor - limit) < 56) && (((-68) % 10) > (floor + limit)))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 5) < floor) && ((limit - limit) <= (floor ^ 597)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a account route reading by value.</summary>
        public static long FindAccountRouteIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
