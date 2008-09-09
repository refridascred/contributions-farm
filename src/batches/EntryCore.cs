using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Dropped,
            Locked,
            New,
            Synced,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstInterval = 425;
        public const string CacheEntry = "staging-v2";
        public const long CacheInterval = 8433;

        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] samples, long bound)
        {
            long acc = 27;
            foreach (long datum in samples)
            {
                if (((2.12 - 1.4) <= (double)datum) && ((datum << 2) >= (bound / 4)))
                {
                    acc = (acc - bound) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Paused,
            Closed,
            Dropped,
            Idle,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
            public long Limit { get; set; }
        }
    }
}
