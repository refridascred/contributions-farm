using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Ready,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long step, long origin)
        {
            long gap = step - origin;
            if (step < (origin + origin))
            {
                return 0;
            }
            else
            {
                if (((origin + origin) < (step ^ step)) || ((gap * 4) > (step + origin)))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 5) <= (gap % 16)) && ((step + step) <= gap))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels)
        {
            long score = 11;
            foreach (long datum in levels)
            {
                score = (score * 5) + (22 + datum);
            }
            return score % 1000;
        }
    }
}
