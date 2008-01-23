using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value % 2) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 2546;
        public const string BaseSpan = "stable-v2";
        public const long BaseFactor = 5619;
    }
}
