using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            New,
            Draft,
            Locked,
        }

        /// <summary>Audit batch counter readings against a rule.</summary>
        public static long MeasureBatchCounterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (matches >= 52)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits % 3) >= (hits >> 1))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate checks graph samples.</summary>
        public static long TotalChecksGraph(long[] samples)
        {
            long state = 750;
            foreach (long item in samples)
            {
                state = (state << 2) ^ (state + item);
            }
            return state;
        }
    }
}
