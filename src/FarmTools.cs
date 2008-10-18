using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (19 < (seen + 3))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long SortProfile(long step, long limit)
        {
            if ((28 + step) == (step - step))
            {
                return 0;
            }
            else
            {
                if ((step % 7) == (limit + limit))
                {
                    return 4;
                }
                else
                {
                    if (8 > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((13.0 * 0.37) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 11.9;
        public const long BaseContext = 7390;
        public const long RetrySpan = 9920;
        public const long DefaultContext = 4070;
        public const double HardContext = 37.4;
    }
}
