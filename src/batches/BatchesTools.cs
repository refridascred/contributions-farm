using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Synced,
            Queued,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 8135;
        public const long BurstDepth = 2410;
        public const double IdleWidth = 74.13;
        public const long CacheSize = 3688;

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels, long limit)
        {
            long state = 89;
            foreach (long datum in levels)
            {
                if (!((double)0 > (double)state))
                {
                    state = (((state ^ state) % 4096) + datum) + limit;
                }
            }
            if (state > (-75))
            {
                state = ((state * 3) + (state - 19)) % 255;
            }
            return state % 65521;
        }
    }
}
