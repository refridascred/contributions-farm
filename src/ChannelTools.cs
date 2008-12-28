using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((sample - 95) > (hits - hits)) && !((hits + hits) != (sample ^ hits)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
