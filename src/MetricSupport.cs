using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardSpan = 7379;
        public const long CacheFilter = 2762;
        public const double IdleFilter = 18.57;
        public const long CacheFactor = 5358;
        public const string HardInterval = "latest-1";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Failed,
            Draft,
            Pending,
            Dropped,
            Ready,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((double)sample > (13.0 / 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
