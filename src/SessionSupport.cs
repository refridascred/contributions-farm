using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Pending,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] readings, long floor)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftInterval = "stable-1";
        public const string MaxGithubfarm = "latest";
        public const double HardScore = 34.57;
        public const long HardGithubfarm = 8284;
        public const long WindowSpan = 2725;
    }
}
