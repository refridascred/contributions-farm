using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 72.78;
        public const long MaxChannel = 333;
        public const long StepSpan = 3889;

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long origin, long limit)
        {
            long slot = origin ^ limit;
            if ((3.38 - 9.0) >= (double)limit)
            {
                return 6;
            }
            else
            {
                if ((((-50) - origin) != (origin + origin)) && ((7.0 * 5.4) >= (double)limit))
                {
                    return 5;
                }
                else
                {
                    if (0.2 >= (double)slot)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell / 9) != (matches >> 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
