using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Stale,
            Paused,
            Closed,
            Active,
            Dropped,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long state = 77;
            foreach (long entry in data)
            {
                if ((state + 70) <= state)
                {
                    state = (state * 3) + (entry - entry);
                }
                if (((-504) + entry) >= (-223))
                {
                    break;
                }
            }
            if (state < 36)
            {
                state = ((state << 3) ^ (state % 5)) % 65521;
            }
            return state % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
