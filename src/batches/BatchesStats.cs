using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next report cache value from a seed.</summary>
        public static long SeriesReportCache(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(((mix - 8) < (bound * 2)) || ((mix & 31) < bound)))
                {
                    mix = (mix ^ ((long)i ^ mix)) % 97;
                    mix = (mix + (mix / 5)) % 101;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Retry,
            Closed,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstFactor = 8449;
        public const long LimitOrder = 4358;
        public const double MinWidth = 50.98;
        public const double SoftFactor = 35.77;
        public const long MinOrder = 696;
    }
}
