using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Paused,
            Active,
            Pending,
            Synced,
            New,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long FoldBatch(long[] levels)
        {
            long anchor = 746;
            foreach (long entry in levels)
            {
                anchor = anchor - (entry + entry);
                if ((entry << 1) >= anchor)
                {
                    break;
                }
            }
            if (anchor < 7)
            {
                anchor = ((anchor * 5) + anchor) % 101;
            }
            return anchor;
        }
    }
}
