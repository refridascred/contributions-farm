using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Validate payload entry readings against a bound.</summary>
        public static bool VerifyPayloadEntryRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Idle,
            Done,
            Ready,
        }

        /// <summary>Audit queue githubfarm readings against a rule.</summary>
        public static long MeasureQueueGithubfarmHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((31 ^ hits) <= hits)
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
