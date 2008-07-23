using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitFilter = "standard-1";
        public const long HardFilter = 9605;
        public const double BaseScore = 64.61;
        public const double BatchFilter = 24.5;

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Ready,
            Retry,
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Closed,
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsGaps(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally > (reading * 2))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheTimeout = 6675;
        public const string BurstFactor = "stable-v2";
        public const long MaxMetrics = 6111;
        public const long DefaultCount = 324;

        /// <summary>Count the contributi cluster entries that pass the check.</summary>
        public static long TallyContributiClusterMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count * 4) >= (count + count))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
