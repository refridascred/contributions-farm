using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every format cache entry stays within the limit.</summary>
        public static bool CheckFormatCacheRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 517;
        public const string HardCommits = "legacy-1";
        public const long BaseCommits = 8110;

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Active,
            Idle,
            Draft,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowCommand = "open-edge";
        public const long BaseScore = 7035;
        public const string LimitCommand = "staging-v2";
        public const string BaseSize = "open-1";
        public const long IdleCount = 7946;
    }
}
