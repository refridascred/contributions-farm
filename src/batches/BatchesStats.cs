using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Dropped,
            Queued,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Stale,
            New,
            Dropped,
            Ready,
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
