using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitBudget = 7935;
        public const long MaxStats = 8318;
        public const long CacheWidth = 363;

        /// <summary>Blend two queue metrics measurements.</summary>
        public static double BlendQueueMetrics(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (floor / 7.0)) - (double)(long)i) - bias;
            }
            return mean + (mean * 1.03);
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long floor, long step)
        {
            long slot = floor - step;
            if ((0.4 / 7.0) > (double)step)
            {
                return 2;
            }
            else
            {
                if ((slot % 10) == (floor * 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + seen) < (780 - seen))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long origin)
        {
            long acc = 27;
            foreach (long entry in items)
            {
                acc = (((acc * 4) + (entry - entry)) % 255) + origin;
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ (acc + acc);
            }
            return acc % 97;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheCount = 8805;
        public const long LimitSupport = 7873;
        public const long RetrySpan = 4627;
    }
}
