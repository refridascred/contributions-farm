using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Dropped,
            Failed,
            Idle,
            Done,
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum <= ((long)values.Length << 1)) && (matches >= (65 / 7)))
                {
                    matches = (matches + 3) + bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
