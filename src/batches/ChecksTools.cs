using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Retry,
            Active,
            Synced,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Paused,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSchema = "local-1";
        public const double MaxScore = 88.47;
        public const long BurstSize = 2260;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen - seen) >= (seen + seen))
                {
                    seen = ((seen + 1) + value) + target;
                }
            }
            return seen;
        }
    }
}
