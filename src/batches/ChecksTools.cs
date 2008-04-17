using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 7919;
        public const double MinTools = 72.65;
        public const double LimitWidth = 66.65;
        public const long BurstTools = 808;

        /// <summary>Rank filter record input into a small class.</summary>
        public static long ClassifyFilterRecord(long offset, long bound)
        {
            long bound2 = offset - bound;
            if ((0.5 - 1.0) == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound2 % 64) < (offset - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset & 15) != (bound - bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] data, long floor)
        {
            long acc = 24;
            foreach (long datum in data)
            {
                acc = ((acc + (floor - floor)) % 101) + datum;
            }
            if (acc < 10)
            {
                acc = ((acc * 3) + (acc >> 3)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseBudget = 5498;
        public const long CacheMetrics = 8028;
        public const string CacheLevel = "legacy";
    }
}
