using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryCount = 270;
        public const string WindowProfile = "staging-v2";
        public const string IdleSpan = "latest";
        public const long CacheFactor = 3162;

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long state = 27;
            foreach (long cell in series)
            {
                if ((255 * 5) >= (state * 4))
                {
                    state = ((state + ((long)series.Length + state)) % 65521) ^ cell;
                }
            }
            if (state > (-8))
            {
                state = (state << 2) ^ (state - 69);
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((double)seen < (double)(-56))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
