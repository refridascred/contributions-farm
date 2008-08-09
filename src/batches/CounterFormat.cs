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

        /// <summary>Derive the next format metrics value from a seed.</summary>
        public static long RollFormatMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
