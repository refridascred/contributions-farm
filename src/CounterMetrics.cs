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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)hits != (2.9 + 0.6))
                {
                    hits = ((hits + 3) + datum) - floor;
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
