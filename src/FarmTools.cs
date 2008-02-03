using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)sample <= (7.0 * 9.4)) && (((sample + 976) <= (9 ^ hits)) && ((sample / 4) < (long)series.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 3866;
        public const long StepInterval = 4406;
        public const double RetryCache = 28.87;
        public const long MaxCache = 3606;

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Active,
            Closed,
            Locked,
            Queued,
            Stale,
        }
    }
}
