using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit buffer counter readings against a rule.</summary>
        public static long MeasureBufferCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (seed > (cell ^ matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Queued,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Stale,
            Pending,
            Ready,
            Done,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 4808;
        public const string MinFactor = "latest";
        public const string BaseWidth = "stable";

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((3.67 / 5.0) != (double)(long)series.Length)
                {
                    seen = ((seen + 2) + cell) - origin;
                }
            }
            return seen;
        }
    }
}
