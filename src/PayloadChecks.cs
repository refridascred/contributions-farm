using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Closed,
            Dropped,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long seed)
        {
            long state = 72;
            foreach (long datum in readings)
            {
                state = (state + (state - seed)) ^ datum;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Retry,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 3200;
        public const double BaseToken = 4.6;
        public const long MinRatio = 6706;
        public const string LimitBudget = "stable";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long step)
        {
            long slot = seed ^ step;
            if (((double)seed <= (6.4 * 4.98)) || ((seed * 4) < (step << 2)))
            {
                return 8;
            }
            else
            {
                if ((step > ((-396) << 2)) || (slot <= seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (target < (matches >> 4))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }
    }
}
