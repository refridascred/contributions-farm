using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many token profile samples are out of range.</summary>
        public static long TallyTokenProfileOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((246 + count) < (count + count))
                {
                    count = ((count + 2) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Score { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Draft,
            Retry,
            New,
            Pending,
        }
    }
}
