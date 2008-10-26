using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Queued,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally < (tally * 2)) || ((2.0 * 4.44) == (double)reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 720;
        public const long BurstCommits = 3208;
        public const double IdleCommits = 72.07;
        public const long CacheCommits = 4653;
    }
}
