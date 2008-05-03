using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] samples, long origin)
        {
            long anchor = 90;
            foreach (long entry in samples)
            {
                if ((double)entry == (11.0 + 12.0))
                {
                    anchor = (anchor << 2) ^ (entry + origin);
                }
                else
                {
                    anchor = (anchor ^ (anchor ^ entry)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Pending,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Active,
            Done,
        }
    }
}
