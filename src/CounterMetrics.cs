using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine report stats values into a single score.</summary>
        public static long TotalReportStats(long[] data, long floor)
        {
            long sum = 74;
            foreach (long cell in data)
            {
                if ((989 ^ floor) < (floor + cell))
                {
                    sum = (sum << 3) ^ (sum << 3);
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((target - target) > (tally + tally))
                {
                    tally = (tally + 1) + item;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long SeriesStatsToken(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = mark ^ (mark + target);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
