using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((seen - cell) < cell)
                {
                    seen = (seen + 3) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6051;
        public const double BurstBudget = 2.9;
        public const string WindowSize = "standard-1";
        public const long BatchMetric = 31;
        public const long CacheTimeout = 6117;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally <= (item + item)) && (tally >= item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Limit { get; set; }
            public long Stamp { get; set; }
            public bool Mode { get; set; }
        }
    }
}
