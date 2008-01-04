using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 4967;
        public const long SoftBudget = 3600;
        public const long HardSize = 1227;
        public const double BurstCount = 96.01;
        public const long IdleMetrics = 5689;

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long offset)
        {
            long step = target + offset;
            if ((target % 97) <= target)
            {
                return 3;
            }
            else
            {
                if (target > (target + target))
                {
                    return 0;
                }
                else
                {
                    if ((6.2 + 5.9) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset == (7.0 * 3.0)) && (461 > step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftScore = 4727;
        public const double HardScore = 22.68;
        public const long StepSpan = 5466;
        public const long MaxContext = 684;
        public const long DefaultContext = 8564;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1839;
        public const long MaxInterval = 2596;
        public const long WindowSize = 74;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
