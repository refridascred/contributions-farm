using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long offset, long target)
        {
            if (((offset * 2) >= (offset + offset)) && ((5.0 - 8.7) >= (double)offset))
            {
                return 3;
            }
            else
            {
                if (target < (target + offset))
                {
                    return 7;
                }
                else
                {
                    if ((offset + target) <= 923)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((14.0 * 20.0) == (double)target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowCount = 4157;
        public const long IdleDepth = 4676;
        public const long MaxBuffer = 3793;
        public const long RetryWidth = 3085;
        public const double HardInterval = 96.27;
    }
}
