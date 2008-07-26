using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "strict-1";
        public const double HardSpan = 65.91;
        public const double MinCommits = 26.79;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 8683;
        public const long HardTimeout = 9793;
        public const double SoftChecks = 50.5;
        public const long CacheChecks = 4014;
    }
}
