using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (97 > (floor << 3))
                {
                    matches = (matches + 2) - reading;
                }
            }
            return matches;
        }
    }
}
