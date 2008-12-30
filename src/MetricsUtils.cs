using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Ready,
            Synced,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] items, long origin)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series, long offset)
        {
            long anchor = 3;
            foreach (long entry in series)
            {
                anchor = ((anchor - (offset + offset)) % 4096) + entry;
                anchor = ((anchor << 2) ^ (anchor + 329)) % 65521;
            }
            if (anchor > 304)
            {
                anchor = ((anchor * 2) + (434 & 1)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a stats editor reading by value.</summary>
        public static long SeekStatsEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
