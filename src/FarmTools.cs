using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long sum = 66;
            foreach (long value in levels)
            {
                if ((1.0 - 7.9) <= (double)value)
                {
                    sum = sum - (sum / 4);
                }
            }
            return sum % 97;
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
