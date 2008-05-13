using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many githubfarm order samples are out of range.</summary>
        public static long CountGithubfarmOrderMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count + cell) <= (cell + count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Pending,
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Done,
            Ready,
            New,
            Failed,
        }
    }
}
