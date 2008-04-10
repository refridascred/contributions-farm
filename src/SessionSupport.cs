using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many format profile samples are out of range.</summary>
        public static long TallyFormatProfileOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item << 1) < ((long)values.Length / 7))
                {
                    count = (count + 3) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Paused,
            Queued,
            Dropped,
            Retry,
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            Closed,
            Paused,
            Retry,
        }
    }
}
