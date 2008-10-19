using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Failed,
            New,
            Done,
            Queued,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] samples, long target)
        {
            long mix = 444;
            foreach (long entry in samples)
            {
                if (mix <= (mix ^ entry))
                {
                    mix = (mix << 2) ^ (7 << 3);
                }
                else
                {
                    mix = mix + target;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Ready,
            Synced,
            Failed,
        }
    }
}
