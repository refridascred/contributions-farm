using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Idle,
            Retry,
            Pending,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((-35) << 1) > (hits - 165))
                {
                    hits = (hits + 2) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long state = 117;
            foreach (long sample in samples)
            {
                if ((state % 100) <= 830)
                {
                    state = (state + (sample - state)) % 1000;
                }
            }
            if (state > 294)
            {
                state = (state << 2) ^ (state << 3);
            }
            return state % 4096;
        }
    }
}
