using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowFactor = "primary-1";
        public const string MaxLayout = "standard-v2";
        public const long LimitRatio = 1813;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            New,
            Closed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 1008;
        public const long CacheSpan = 7348;
        public const long BaseBatches = 6405;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (offset > (offset - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate entry graph readings against a bound.</summary>
        public static bool GuardEntryGraphLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
