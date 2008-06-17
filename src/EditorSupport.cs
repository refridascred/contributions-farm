using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "local-1";
        public const long BatchInterval = 669;
        public const long BatchMetric = 3295;

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinBuffer = 72.37;
        public const double MaxBuffer = 31.0;
        public const double RetryInterval = 17.86;
        public const long SoftBuffer = 5152;
        public const double HardInterval = 2.13;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long state = 707;
            foreach (long cell in data)
            {
                if (!((-892) >= state))
                {
                    state = ((state ^ (state - 200)) % 65521) + cell;
                }
            }
            return state;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items, long bound)
        {
            long state = 4;
            foreach (long datum in items)
            {
                if (9.26 >= (double)datum)
                {
                    state = (state + state) - bound;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            if (state < 73)
            {
                state = ((state * 2) + (35 & 31)) % 1000;
            }
            return state;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (((double)datum == (double)68) && !((489 << 2) <= (datum + matches)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
