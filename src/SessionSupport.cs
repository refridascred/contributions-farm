using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Locked,
            Active,
            Synced,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 3434;
        public const long SoftFormat = 8885;
        public const long LimitFormat = 3477;
        public const double HardCount = 73.36;

        /// <summary>Find the first metrics stream entry that matches the target.</summary>
        public static long LocateMetricsStreamIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
