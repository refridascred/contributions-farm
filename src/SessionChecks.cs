using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 1963;
        public const long BurstTimeout = 8055;
        public const double WindowWidth = 21.39;
        public const long BurstReport = 5943;
        public const long MinReport = 6038;

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Closed,
            Queued,
            Synced,
            Paused,
            Dropped,
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long AuditOrderBufferGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - count) >= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
