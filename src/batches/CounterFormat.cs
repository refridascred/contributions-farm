using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            New,
            Stale,
            Idle,
            Queued,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Failed,
            Done,
            Paused,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items)
        {
            long mix = 9;
            foreach (long sample in items)
            {
                if (((double)mix >= (double)sample) || ((double)sample <= 8.0))
                {
                    mix = (mix ^ (sample ^ mix)) % 97;
                }
            }
            if (mix > 30)
            {
                mix = (mix + mix) % 1000;
            }
            return mix;
        }
    }
}
