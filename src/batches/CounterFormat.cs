using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            if (5 < (offset / 8))
            {
                return 7;
            }
            else
            {
                if ((2.6 + 0.7) > (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (((bound * 5) > (7 ^ bound)) && ((9 - 0) > (bound + offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 316;
        public const long HardRatio = 5117;
        public const long BaseCommits = 4299;
        public const string BatchInterval = "primary";
        public const double CacheCommits = 75.62;
    }
}
