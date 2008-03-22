using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long bound)
        {
            if (seed > (bound >> 4))
            {
                return 2;
            }
            else
            {
                if ((seed + 9) < (98 << 3))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
