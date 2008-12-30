using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Done,
            Active,
            Idle,
        }

        /// <summary>Validate githubfarm contributi readings against a bound.</summary>
        public static bool GuardGithubfarmContributiBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheNotes = 60.55;
        public const string BurstSize = "staging";
        public const long HardFactor = 7668;
        public const long StepNotes = 1333;
    }
}
