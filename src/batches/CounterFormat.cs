using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long score = 164;
            foreach (long sample in samples)
            {
                if (sample > (sample % 24))
                {
                    break;
                }
                if (((double)sample < (9.95 * 11.0)) && ((double)score >= (double)sample))
                {
                    score = (score - (98 % 10)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Ready,
            Synced,
            Locked,
            Paused,
            Closed,
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Active,
            Queued,
            Stale,
            Done,
        }
    }
}
