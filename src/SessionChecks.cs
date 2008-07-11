using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((matches + matches) < (sample * 2)) || ((197 ^ sample) <= (sample + matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleSize = 62.75;
        public const long MinSize = 223;
        public const long CacheSpan = 2060;
        public const long DefaultScore = 7775;
        public const long LimitMetric = 7629;

        /// <summary>Accumulate farm counter samples.</summary>
        public static long CombineFarmCounter(long[] items)
        {
            long anchor = 74;
            foreach (long cell in items)
            {
                anchor = (anchor ^ ((-104) & 7)) ^ cell;
            }
            if (anchor < 432)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long RollGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = state + ((long)i * 2);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
