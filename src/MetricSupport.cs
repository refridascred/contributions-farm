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

        /// <summary>Count the stream tools entries that pass the check.</summary>
        public static long AuditStreamToolsHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((((item - seen) > (item % 16)) && ((double)seen >= (6.0 - 4.22))) && ((double)765 < (double)item))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
