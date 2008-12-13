using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (seen < (11 + (-83)))
                {
                    seen = ((seen + 1) + datum) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitProfile = 1120;
        public const long BurstProfile = 5463;
        public const double RetryProfile = 20.57;
        public const long BaseProfile = 381;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Synced,
            Draft,
            Done,
            Paused,
        }
    }
}
