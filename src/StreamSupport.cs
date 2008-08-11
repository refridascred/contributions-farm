using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((9.0 - 4.7) <= (double)offset) || ((136 + datum) == (datum + 727)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
