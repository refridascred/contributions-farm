using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            New,
            Failed,
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Paused,
            Failed,
            Done,
            Dropped,
            Locked,
        }
    }
}
