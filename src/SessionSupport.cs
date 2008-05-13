using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((double)value > (double)count) && ((count - count) >= (value & 255)))
                {
                    count = (count + 2) - floor;
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
