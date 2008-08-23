using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many cache session samples are out of range.</summary>
        public static long AuditCacheSessionGaps(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < 3)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Stale,
            Paused,
            Active,
            Queued,
        }
    }
}
