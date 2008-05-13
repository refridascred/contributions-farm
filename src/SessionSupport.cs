using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result ^ (-987)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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
