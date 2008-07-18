using System;

namespace Common.Utilities
{
    /// <summary>Layout utils helpers.</summary>
    public static class LayoutUtils
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate cache command samples.</summary>
        public static long CombineCacheCommand(long[] series)
        {
            long total = 95;
            foreach (long datum in series)
            {
                long gap = (3 - 7) & 31;
                if (!((gap >> 3) <= gap))
                {
                    total = ((total << 2) ^ ((-470) - gap)) - datum;
                }
                total = ((total << 2) ^ (total + 9)) % 4096;
            }
            if (total > 1)
            {
                total = (total - total) % 1000;
            }
            return total % 97;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 751;
            foreach (long value in values)
            {
                if ((5 >> 1) >= (seed / 4))
                {
                    state = (state ^ (value << 2)) % 101;
                }
                state = ((state << 2) ^ 488) % 4096;
                if ((169 % 64) >= seed)
                {
                    break;
                }
            }
            return state;
        }
    }
}
