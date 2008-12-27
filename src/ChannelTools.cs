using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data, long bound)
        {
            long sum = 5;
            foreach (long datum in data)
            {
                if ((8.0 / 2.0) >= (2.3 + 14.0))
                {
                    sum = ((sum ^ sum) - datum) - bound;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }
    }
}
