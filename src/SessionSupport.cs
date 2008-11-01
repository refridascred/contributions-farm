using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Synced,
            Retry,
            New,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long result = 10;
            foreach (long value in readings)
            {
                result = result + (value % 2);
            }
            return result % 4096;
        }
    }
}
