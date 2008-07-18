using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the session route entries that pass the check.</summary>
        public static long AuditSessionRouteOutliers(long[] readings, long target)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) == (matches * 3))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            New,
            Paused,
            Idle,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Size { get; set; }
            public bool Label { get; set; }
        }
    }
}
