using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((limit + matches) <= (entry + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryFactor = 1305;
        public const long LimitFactor = 3637;
        public const string RetrySpan = "open-1";

        /// <summary>Validate notes queue readings against a bound.</summary>
        public static bool VerifyNotesQueueLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
