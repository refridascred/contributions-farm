using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
