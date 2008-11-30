using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every contributi cache entry stays within the limit.</summary>
        public static bool GuardContributiCacheLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((-1) >= (datum + 81))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
