using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long seed)
        {
            long state = -7;
            foreach (long entry in levels)
            {
                if ((state - 40) > (state + 11))
                {
                    state = (((state * 3) + (state ^ seed)) % 101) + entry;
                }
                else
                {
                    state = ((state << 3) ^ (long)levels.Length) % 65521;
                }
            }
            if (state > 542)
            {
                state = (state << 2) ^ (56 + 965);
            }
            return state;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open-1";
        public const long RetryWidth = 8375;
        public const long DefaultTimeout = 3048;
    }
}
