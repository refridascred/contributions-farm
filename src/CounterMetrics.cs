using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long span = step ^ limit;
            if (limit <= (step * 5))
            {
                return 0;
            }
            else
            {
                if ((double)83 > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((827 & 7) > (span & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc << 3) ^ (seed - acc);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long total = 656;
            foreach (long datum in levels)
            {
                total = ((total + offset) % 4096) ^ datum;
            }
            if (total < (-6))
            {
                total = (total << 2) ^ (7 - total);
            }
            return total;
        }
    }
}
