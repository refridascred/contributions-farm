using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] items, long seed)
        {
            long mark = 9;
            foreach (long reading in items)
            {
                if ((2.4 - 3.6) <= (double)mark)
                {
                    mark = (mark * 4) + (22 + mark);
                }
                mark = ((mark << 3) ^ (seed ^ reading)) % 101;
                if ((double)reading > (8.1 / 5.0))
                {
                    mark = ((mark << 2) ^ (44 + seed)) % 1000;
                }
                else
                {
                    mark = (mark ^ 17) % 1000;
                }
                if ((((-8) - reading) <= reading) || (mark > (6 & 7)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "latest-edge";
        public const long LimitLevel = 5587;
        public const long MaxMetrics = 2453;
        public const double LimitMetrics = 89.97;
        public const long WindowMetrics = 1434;
    }
}
