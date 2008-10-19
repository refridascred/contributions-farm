using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((tally + 12) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Draft,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Synced,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 88.73;
        public const long RetryRatio = 7972;
        public const long BaseStats = 3359;
        public const double BurstStats = 72.65;
    }
}
