using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long DeriveRoute(long offset)
        {
            long total = offset;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
