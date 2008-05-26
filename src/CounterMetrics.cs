using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next order metrics value from a seed.</summary>
        public static long DeriveOrderMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + 6) % 65521;
                mark = mark + (seed << 2);
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Validate graph stats readings against a bound.</summary>
        public static bool ValidateGraphStatsRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardTimeout = "staging-v2";
        public const long DefaultSize = 8317;
        public const long BatchCount = 726;

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count <= (count % 8))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }
    }
}
