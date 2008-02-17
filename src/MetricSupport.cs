using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if (offset <= origin)
            {
                return 5;
            }
            else
            {
                if ((65 & 1) >= (offset - offset))
                {
                    return 7;
                }
                else
                {
                    if (!(8.92 < (double)origin))
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsMatches(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 1) <= hits)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchCount = 115;
        public const long BatchProfile = 3221;
        public const double BatchFactor = 59.57;
        public const double LimitProfile = 23.74;
        public const double SoftProfile = 61.28;
    }
}
