using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the counter schema entries that pass the check.</summary>
        public static long CountCounterSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((-1) > (tally << 3))
                {
                    tally = (tally + 2) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long target, long limit)
        {
            if (((-1) - limit) < (68 << 2))
            {
                return 2;
            }
            else
            {
                if ((target >> 2) < ((-1) % 16))
                {
                    return 4;
                }
                else
                {
                    if ((target <= (target + 19)) && ((target + limit) < (limit ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
