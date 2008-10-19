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

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleQueue = 7289;
        public const string MinQueue = "primary-edge";
        public const long CacheQueue = 7470;
        public const string CacheSize = "open-v2";
    }
}
