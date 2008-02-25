using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Failed,
            Closed,
            Ready,
            Done,
        }
    }
}
