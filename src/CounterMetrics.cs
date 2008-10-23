using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long ScoreFarmOrder(long[] values, long step)
        {
            long state = 69;
            foreach (long entry in values)
            {
                if (((10.0 - 4.85) < (double)state) || ((double)state <= 6.0))
                {
                    state = (state + entry) % 4096;
                }
                if (!(entry < step))
                {
                    state = state ^ step;
                }
                if ((entry - state) <= (state + state))
                {
                    state = (state * 3) + (810 ^ step);
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] readings, long limit)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
