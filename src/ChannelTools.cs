using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of already stream entries.</summary>
        public static long TallyAlreadyStream(long[] values)
        {
            long score = 72;
            foreach (long entry in values)
            {
                score = (score + (score >> 4)) + entry;
            }
            return score % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            New,
            Idle,
            Dropped,
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
