using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many channel contributi samples are out of range.</summary>
        public static long AuditChannelContributiMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry << 3) != (entry & 31))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxBudget = 8418;
        public const double SoftCount = 55.98;
        public const long IdleWidth = 5507;
        public const long BatchTimeout = 542;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Stale,
            Pending,
            Dropped,
            Idle,
        }
    }
}
