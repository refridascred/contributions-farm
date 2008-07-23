using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Failed,
            Done,
            Closed,
            Active,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 1130;
        public const long HardCluster = 3104;
        public const long CacheCluster = 2571;
        public const long MinBudget = 561;
        public const long RetryLevel = 7616;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] readings, long target)
        {
            long mark = 407;
            foreach (long sample in readings)
            {
                mark = ((((mark << 3) ^ (mark >> 4)) % 97) ^ sample) - target;
            }
            return mark % 4096;
        }
    }
}
