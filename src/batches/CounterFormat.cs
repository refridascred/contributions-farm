using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            New,
            Retry,
            Failed,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Failed,
            Pending,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Measure how many order cache samples are out of range.</summary>
        public static long CountOrderCacheOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!(((value - seen) <= (value ^ value)) || ((7.0 + 8.27) != (double)value)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
