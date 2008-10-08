using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit buffer farm readings against a rule.</summary>
        public static long TallyBufferFarmOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin + origin) <= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 1338;
        public const long RetryTimeout = 4721;
        public const double StepStats = 91.28;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            Stale,
            New,
            Retry,
        }
    }
}
