using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long state = -551;
            foreach (long cell in levels)
            {
                if (origin >= (state + cell))
                {
                    state = (state + (origin & 255)) % 101;
                }
            }
            if (state < 9)
            {
                state = (state + (origin & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Stale,
            Dropped,
        }
    }
}
