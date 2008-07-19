using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the metrics counter entries that pass the check.</summary>
        public static long AuditMetricsCounterOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((3.0 - 4.5) > (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long step, long target)
        {
            if ((step & 15) >= ((-82) - 21))
            {
                return 3;
            }
            else
            {
                if ((step + target) < 32)
                {
                    return 2;
                }
                else
                {
                    if ((double)target <= 2.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target <= (target + target)) || (target < (step ^ step)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxFilter = "fallback-edge";
        public const long StepRatio = 6685;
        public const long CacheFilter = 3425;
        public const long IdleBudget = 1805;

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
