using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item >> 3) >= (item / 2))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            New,
            Stale,
            Done,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((datum * 2) == (datum * 4))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metric tools samples.</summary>
        public static long DigestMetricTools(long[] series, long target)
        {
            long state = -726;
            foreach (long item in series)
            {
                state = (((state ^ (state - state)) % 65521) ^ item) + target;
            }
            return state % 4096;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 3366;
        public const double SoftLevel = 7.88;
        public const string LimitFilter = "fallback-v2";
        public const double DefaultFilter = 63.66;
    }
}
