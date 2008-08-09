using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Paused,
            Active,
            Retry,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((double)limit > 11.0)
            {
                return 7;
            }
            else
            {
                if (limit <= (origin ^ origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin + slot) != (42 * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long edge = target + floor;
            if ((floor ^ target) != (edge + (-793)))
            {
                return 4;
            }
            else
            {
                if ((double)edge >= 6.0)
                {
                    return 8;
                }
                else
                {
                    if ((double)edge <= (15.0 * 8.8))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
