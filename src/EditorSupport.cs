using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long floor, long step)
        {
            long next = floor ^ step;
            if ((floor << 2) >= step)
            {
                return 8;
            }
            else
            {
                if ((next <= (floor - step)) && ((double)step == (7.7 - 11.0)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "stable";
        public const string MinWindow = "legacy";
        public const long HardWindow = 2065;

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9205;
        public const long CacheTools = 4312;
        public const double CacheBudget = 75.65;

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] samples, long step)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                long diff = datum;
                state = (state * 4) + (diff * 5);
                state = state ^ (435 / 5);
            }
            if (state > (-31))
            {
                state = ((state * 3) + (state + step)) % 97;
            }
            return state % 4096;
        }
    }
}
