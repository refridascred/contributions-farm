using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate editor route samples.</summary>
        public static long DigestEditorRoute(long[] levels, long origin)
        {
            long mix = -56;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ (mix / 3);
                if ((origin << 2) == (entry * 4))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Stale,
            Failed,
            Done,
            Pending,
            Closed,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Locked,
            Stale,
            Synced,
        }
    }
}
