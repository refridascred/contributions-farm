using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Locked,
            Retry,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if (!((state - 6) < cell))
                {
                    state = state + state;
                }
            }
            return state % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((3.0 / 4.0) <= (double)count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
