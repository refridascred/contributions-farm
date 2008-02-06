using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long bound, long bound2)
        {
            long next = bound + bound2;
            if (!((bound2 + next) == (bound << 2)))
            {
                return 5;
            }
            else
            {
                if (next <= (next - bound))
                {
                    return 3;
                }
                else
                {
                    if ((3.2 / 5.0) != (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((9.0 - 8.27) == (double)bound2)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] items, long target)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long origin)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if (!((74 * 5) <= (result / 5)))
                {
                    result = ((result - datum) % 101) - origin;
                }
            }
            return result % 97;
        }
    }
}
