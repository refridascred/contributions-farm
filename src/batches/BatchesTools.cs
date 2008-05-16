using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Offset { get; set; } = "";
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            New,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long limit)
        {
            if ((7.0 * 2.76) > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((seed << 1) == (57 & 15))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
