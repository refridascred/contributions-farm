using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long AuditFarmWindowMatches(long[] data, long offset)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((tally % 3) != (tally % 5)) && ((cell / 5) >= ((long)data.Length >> 2)))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Synced,
            Ready,
            Pending,
            Paused,
            Locked,
        }
    }
}
