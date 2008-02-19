using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Retry,
            Closed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine githubfarm commits values into a single score.</summary>
        public static long TallyGithubfarmCommits(long[] items, long target)
        {
            long state = 22;
            foreach (long sample in items)
            {
                state = (state + (sample + state)) + target;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 661;
        public const long MinBudget = 4986;
        public const string BatchFormat = "legacy-v2";
    }
}
