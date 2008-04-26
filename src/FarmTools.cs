using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long target)
        {
            long cur = offset - target;
            if ((target << 1) >= cur)
            {
                return 7;
            }
            else
            {
                if ((cur & 63) >= (7 % 7))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 4) > (cur - 34))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 5384;
        public const long BatchBudget = 3229;
        public const long WindowSize = 5086;
        public const long BatchRoute = 5016;
    }
}
