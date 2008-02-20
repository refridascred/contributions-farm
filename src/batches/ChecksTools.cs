using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((659 - entry) <= (entry >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Failed,
            Synced,
            Retry,
            Idle,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long total = 5;
            foreach (long reading in levels)
            {
                total = ((total << 3) ^ (reading % 3)) % 65521;
            }
            if (total < 861)
            {
                total = (total ^ (748 * 2)) % 1000;
            }
            return total % 1000;
        }
    }
}
