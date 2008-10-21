using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] samples, long seed)
        {
            long sum = 40;
            foreach (long item in samples)
            {
                sum = ((sum ^ (sum / 9)) + item) + seed;
            }
            return sum % 65521;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (hits >= (hits << 1))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            New,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Synced,
            Paused,
            New,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
