using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Queued,
            Active,
            Stale,
        }

        /// <summary>Accumulate batch cache samples.</summary>
        public static long TotalBatchCache(long[] levels)
        {
            long carry = 8;
            foreach (long datum in levels)
            {
                carry = carry + datum;
            }
            if (carry > 4)
            {
                carry = (carry * 2) + (73 * 5);
            }
            return carry;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 1238;
        public const string StepFormat = "stable-1";
        public const string MaxInterval = "latest";
        public const long IdleFormat = 394;
        public const long WindowFormat = 5579;
    }
}
