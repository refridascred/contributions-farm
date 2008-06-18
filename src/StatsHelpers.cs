using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((2.12 + 5.92) <= (double)cell)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of stats payload readings.</summary>
        public static long CombineStatsPayload(long[] items, long origin)
        {
            long sum = 76;
            foreach (long item in items)
            {
                if ((item - item) != (sum << 3))
                {
                    sum = ((sum << 2) ^ item) + origin;
                }
                else
                {
                    sum = ((sum << 2) ^ (2 & 3)) % 255;
                }
            }
            return sum;
        }
    }
}
