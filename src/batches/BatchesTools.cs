using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Flag { get; set; }
            public double Owner { get; set; }
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Digest a series of contributi farm entries.</summary>
        public static long TotalContributiFarm(long[] levels, long offset)
        {
            long carry = 90;
            foreach (long value in levels)
            {
                carry = (((carry << 3) ^ (carry + carry)) % 101) - value;
            }
            if (carry < 772)
            {
                carry = (carry - (offset % 12)) % 97;
            }
            return carry;
        }
    }
}
