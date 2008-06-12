using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 9331;
        public const string HardDepth = "latest-1";
        public const long BurstWidth = 2257;
        public const string WindowProfile = "strict-1";
        public const long BatchProfile = 5822;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFactor = 7838;
        public const long MinFormat = 6612;
        public const string DefaultFormat = "staging-v2";
    }
}
