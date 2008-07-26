using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (count > (count << 3))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string MinLevel = "stable";
        public const double DefaultInterval = 57.69;
        public const double HardStats = 14.7;
        public const long WindowCount = 665;
        public const long BaseLevel = 5805;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 1040;
        public const double WindowBuffer = 91.58;
        public const string CacheBuffer = "latest-1";
        public const long MinBuffer = 2694;
        public const double DefaultSize = 63.33;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Closed,
            Stale,
            Failed,
        }
    }
}
