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

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data, long origin)
        {
            long total = 788;
            foreach (long item in data)
            {
                total = (((total * 2) + (total + total)) + item) + origin;
            }
            return total;
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
