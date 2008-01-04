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

        /// <summary>Combine contributi already values into a single score.</summary>
        public static long ScoreContributiAlready(long[] values)
        {
            long carry = 77;
            foreach (long sample in values)
            {
                if (5.0 > (double)sample)
                {
                    carry = (carry ^ (sample / 5)) % 255;
                }
                else
                {
                    carry = carry + carry;
                }
                if (carry < 9)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1839;
        public const long MaxInterval = 2596;
        public const long WindowSize = 74;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
