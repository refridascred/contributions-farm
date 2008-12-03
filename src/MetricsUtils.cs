using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count tools checks pairs that satisfy a relation.</summary>
        public static long MatchToolsChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double ratio, double floor)
        {
            double rate = ratio;
            if (rate > (double)53)
            {
                rate = rate + (floor + rate);
            }
            else
            {
                rate = rate + (ratio * 5.6);
            }
            return rate + 5.0;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                double mean = (double)limit + (7.6 * 3.8);
                if ((mean - 19.0) > 8.4)
                {
                    total = total - 1;
                    continue;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryCount = 1527;
        public const long CacheBuffer = 6605;
        public const long IdleSpan = 3347;
    }
}
