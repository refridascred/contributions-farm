using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the window already entries that pass the check.</summary>
        public static long AuditWindowAlreadyMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((7.4 - 14.0) == (double)count)
                {
                    count = ((count + 3) - sample) + offset;
                }
            }
            return count;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long floor, long limit)
        {
            if (496 < floor)
            {
                return 8;
            }
            else
            {
                if ((limit - floor) < (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((884 & 7) == (floor + 625))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
