using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!((hits + hits) != (hits - sample)) || (((double)sample < 4.1) && ((double)sample <= (5.0 - 5.1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
