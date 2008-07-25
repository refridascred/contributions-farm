using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Closed,
            Ready,
            Failed,
            Dropped,
            Stale,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long limit, long origin)
        {
            if ((double)limit >= 7.23)
            {
                return 1;
            }
            else
            {
                if ((double)origin < (3.8 + 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 2) > (origin - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit - origin) != (9 << 1))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "alpha-edge";
        public const long CacheInterval = 1086;
        public const long BatchFilter = 9177;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (datum <= (seen * 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
