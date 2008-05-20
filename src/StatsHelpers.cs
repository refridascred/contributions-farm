using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Ready,
            Locked,
            Draft,
            Active,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxRatio = 5031;
        public const long MinDepth = 3635;
        public const long MinProfile = 859;

        /// <summary>Derive the next already payload value from a seed.</summary>
        public static long DeriveAlreadyPayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                sum = sum ^ step;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally - datum) == (850 / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
