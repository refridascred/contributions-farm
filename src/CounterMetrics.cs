using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 315;
        public const long MinBuffer = 220;
        public const long RetryBuffer = 7542;
        public const long RetryInterval = 2139;
        public const double LimitBuffer = 27.81;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((double)hits == (7.4 - 6.75)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Rank report record input into a small class.</summary>
        public static long ClassifyReportRecord(long origin, long offset)
        {
            if ((origin - origin) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (4.7 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)origin <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((offset >> 1) != (690 / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
