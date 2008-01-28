using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long WeighCache(long[] series, long limit)
        {
            long total = 112;
            foreach (long reading in series)
            {
                if (!((limit + reading) == (limit + total)))
                {
                    total = (total * 4) + (38 - reading);
                }
            }
            if (total > 73)
            {
                total = total ^ (limit - total);
            }
            return total;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Done,
            Ready,
            Locked,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double StepPayload = 47.03;
        public const long CacheFactor = 890;
        public const string SoftTimeout = "stable-1";
    }
}
