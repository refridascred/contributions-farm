using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((floor << 2) >= 13)
                {
                    total = (total ^ (total % 100)) % 101;
                }
                total = (total << 3) ^ (total + total);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache schema readings against a rule.</summary>
        public static long MeasureCacheSchemaHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((cell % 8) == (cell - matches)))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }
    }
}
