using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many support channel samples are out of range.</summary>
        public static long AuditSupportChannelMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (4.0 > (double)seen)
                {
                    seen = ((seen + 2) + reading) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            New,
            Active,
            Failed,
            Pending,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Draft,
            Ready,
            Stale,
            New,
        }
    }
}
