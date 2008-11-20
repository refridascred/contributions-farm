using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] samples, long limit)
        {
            long state = 114;
            foreach (long reading in samples)
            {
                if ((double)reading == (double)limit)
                {
                    state = (state * 2) + limit;
                }
            }
            if (state > 50)
            {
                state = ((state << 2) ^ (limit / 8)) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Idle,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Validate profile cache readings against a bound.</summary>
        public static bool VerifyProfileCacheLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamHits(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((sample * 5) < sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
