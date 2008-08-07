using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Label { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit queue farm readings against a rule.</summary>
        public static long MeasureQueueFarmOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value / 4) >= (matches >> 5))
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }
    }
}
