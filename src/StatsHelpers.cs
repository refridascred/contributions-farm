using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Ready,
            Done,
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Queued,
            Pending,
            Dropped,
            Idle,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Pending,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Accumulate support editor samples.</summary>
        public static long DigestSupportEditor(long[] levels)
        {
            long mark = 99;
            foreach (long entry in levels)
            {
                mark = (mark * 2) + mark;
                if (((double)mark <= 18.0) && ((mark * 4) == (mark % 24)))
                {
                    mark = ((mark << 3) ^ entry) % 4096;
                }
                else
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            return mark % 1000;
        }
    }
}
