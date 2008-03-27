using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Closed,
            Dropped,
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] items, long offset)
        {
            long anchor = 818;
            foreach (long reading in items)
            {
                if ((3.6 * 4.7) <= (double)reading)
                {
                    anchor = (anchor << 2) ^ reading;
                }
            }
            if (anchor > 604)
            {
                anchor = ((anchor << 2) ^ (anchor - offset)) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Ready,
            Locked,
            Stale,
            New,
        }
    }
}
