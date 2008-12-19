using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first channel cache entry that matches the target.</summary>
        public static long FindChannelCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double CacheCount = 38.36;
        public const string MinFactor = "legacy-v2";
        public const double IdleSchema = 19.15;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(2 <= (seen - 9)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Queued,
            Ready,
            Idle,
            Dropped,
        }
    }
}
